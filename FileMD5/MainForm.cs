using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace FileMD5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "请选择文件";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_file.Text = fileDialog.FileName;
                textBox_result.Text = "";
                FileInfo file = new FileInfo(fileDialog.FileName);
                fileSzie = file.Length;
                showFilesize(fileSzie);
                button_calc.PerformClick();
            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            checkResult();
        }

        MD5 md5 = (MD5)CryptoConfig.CreateFromName("MD5");
        long fileSzie = 0;

        private void button_calc_Click(object sender, EventArgs e)
        {
            string file = textBox_file.Text;

            if (file.Length == 0)
            {
                textBox_result.Text = "请先重新选择文件!";
                return;
            }

            FileStream fs = null;
            try
            {
                fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            }
            catch (SystemException)
            {
                textBox_result.Text = "文件打开错误,请重新选择文件!";
                return;
            }

            //对于大于 100M 的文件启用多线程
            if (fs.Length > 100L * 1024 * 1024)
            {

                //string message = "文件已经超过 100M ，需要较长的计算时间。\n软件将启动后台线程进行处理。是否继续？";
                //string caption = "文件较大";
                //MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //if (MessageBox.Show(message, caption, buttons) == System.Windows.Forms.DialogResult.No)
                //{
                //    fs.Close();
                //    textBox_result.Text = "文件较大，未计算。";
                //    return;
                //}
                textBox_result.Text = "正在计算中，请稍候......";
                button_calc.Enabled = false;
                button_file.Enabled = false;

                Thread thread = new Thread(new ParameterizedThreadStart(calcMD5));
                thread.Start(fs);

            }
            else
            {
                calcMD5(fs);
            }
        }

        //建立一个 object 参数的函数，是为了处理线程调用中，使用参数的问题。
        private void calcMD5(object fs)
        {
            calcMD5((FileStream)fs);
        }

        // Invoke 函数需要使用的委托
        delegate void updateWindows(byte[] result);

        private void calcMD5(FileStream fs)
        {
            byte[] md5byte = md5.ComputeHash(fs);

            if (this.InvokeRequired)
            {
                this.Invoke(new updateWindows(showResult), md5byte);
            }
            else
            {
                showResult(md5byte);
            }
            fs.Close();
        }

        private void showResult(byte[] md5byte)
        {
            int i, j;
            StringBuilder sb = new StringBuilder(32);
            foreach (byte b in md5byte)
            {
                i = Convert.ToInt32(b);
                j = i >> 4;
                sb.Append(Convert.ToString(j, 16));
                j = ((i << 4) & 0x00ff) >> 4;
                sb.Append(Convert.ToString(j, 16));
            }

            String result = sb.ToString().ToUpper();

            textBox_result.Text = result;
            button_calc.Enabled = true;
            button_file.Enabled = true;
            checkResult();

        }

        private void checkResult()
        {

            string result = textBox_result.Text;

            if (textBox_md5.Text.Length == 0)
            {
                textBox_compare.Text = "";
                textBox_compare.Visible = false;
                return;
            }

            if (result.Length != 32)
            {
                textBox_compare.Visible = true;
                textBox_compare.BackColor = Color.Pink;
                textBox_compare.Text = "计算结果框中不是MD5码，请先进行计算！";
                return;
            }

            if (textBox_md5.Text.Trim().ToUpper().Equals(result.ToUpper()))
            {
                textBox_compare.Visible = true;
                textBox_compare.BackColor = Color.LightGreen;
                textBox_compare.Text = "MD5码 已匹配，文件未被修改，可放心使用！";
            }
            else
            {
                textBox_compare.Visible = true;
                textBox_compare.BackColor = Color.Red;
                textBox_compare.Text = "MD5码 不匹配，文件已被修改，请小心！";
            }
        }

        private void showFilesize(long size)
        {

            float d_size;
            string unit = "Byte";

            if (size > 1024 * 1024 * 1024)
            {    //大于 1G 的显示
                d_size = size / (float)(1024 * 1024 * 1024);
                unit = "GB";
            }
            else
            {
                if (size > 1024 * 1024)
                {    //大于 1M 的显示
                    d_size = size / (float)(1024 * 1024);
                    unit = "MB";
                }
                else
                {
                    if (size > 1024)
                    {    //大于 1K 的显示
                        d_size = size / (float)(1024);
                        unit = "KB";
                    }
                    else
                    {
                        d_size = size;
                    }
                }
            }
            textBox_filesize.Text = string.Format(" {0:F} {1} ( {2:N0}字节 )", d_size, unit, size);
        }

        private void textBox_file_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
                this.textBox_file.Cursor = System.Windows.Forms.Cursors.Arrow;  //指定鼠标形状（更好看）
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox_file_DragDrop(object sender, DragEventArgs e)
        {
            //GetValue(0) 为第1个文件全路径
            //DataFormats 数据的格式，下有多个静态属性都为string型，除FileDrop格式外还有Bitmap,Text,WaveAudio等格式
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            textBox_file.Text = path;
            this.textBox_file.Cursor = System.Windows.Forms.Cursors.IBeam; //还原鼠标形状
            if (textBox_md5.Text.Length > 0) //如果拖放文件前已经事先填写正确的md5，则自动计算和对比md5
            {
                button_calc.PerformClick();
                FileInfo file = new FileInfo(path);
                fileSzie = file.Length;
                showFilesize(fileSzie);
            }
        }

        private void pictureBox_paste_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                textBox_md5.Text = (String)iData.GetData(DataFormats.Text);
            }
        }
    }
}
