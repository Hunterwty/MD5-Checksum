namespace FileMD5 {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.button_file = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_md5 = new System.Windows.Forms.TextBox();
            this.button_calc = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_compare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_filesize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.pictureBox_paste = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_paste)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_file
            // 
            this.textBox_file.AllowDrop = true;
            this.textBox_file.Location = new System.Drawing.Point(159, 20);
            this.textBox_file.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.ReadOnly = true;
            this.textBox_file.Size = new System.Drawing.Size(580, 28);
            this.textBox_file.TabIndex = 0;
            this.textBox_file.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_file_DragDrop);
            this.textBox_file.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_file_DragEnter);
            // 
            // button_file
            // 
            this.button_file.Location = new System.Drawing.Point(18, 18);
            this.button_file.Margin = new System.Windows.Forms.Padding(4);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(132, 33);
            this.button_file.TabIndex = 1;
            this.button_file.Text = "选择文件";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(159, 105);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(408, 28);
            this.textBox_result.TabIndex = 2;
            // 
            // textBox_md5
            // 
            this.textBox_md5.Location = new System.Drawing.Point(159, 150);
            this.textBox_md5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_md5.Name = "textBox_md5";
            this.textBox_md5.Size = new System.Drawing.Size(408, 28);
            this.textBox_md5.TabIndex = 3;
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(613, 60);
            this.button_calc.Margin = new System.Windows.Forms.Padding(4);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(126, 45);
            this.button_calc.TabIndex = 4;
            this.button_calc.Text = "计算";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // button_exit
            // 
            this.button_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_exit.Location = new System.Drawing.Point(613, 184);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(126, 45);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "计算结果:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "正确的MD5码:";
            // 
            // textBox_compare
            // 
            this.textBox_compare.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_compare.Location = new System.Drawing.Point(159, 196);
            this.textBox_compare.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_compare.Name = "textBox_compare";
            this.textBox_compare.ReadOnly = true;
            this.textBox_compare.Size = new System.Drawing.Size(408, 28);
            this.textBox_compare.TabIndex = 8;
            this.textBox_compare.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "对比结果:";
            // 
            // textBox_filesize
            // 
            this.textBox_filesize.Location = new System.Drawing.Point(159, 60);
            this.textBox_filesize.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_filesize.Name = "textBox_filesize";
            this.textBox_filesize.ReadOnly = true;
            this.textBox_filesize.Size = new System.Drawing.Size(408, 28);
            this.textBox_filesize.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "文件大小:";
            // 
            // button_check
            // 
            this.button_check.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_check.Location = new System.Drawing.Point(613, 123);
            this.button_check.Margin = new System.Windows.Forms.Padding(4);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(126, 45);
            this.button_check.TabIndex = 5;
            this.button_check.Text = "对比";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // pictureBox_paste
            // 
            this.pictureBox_paste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_paste.BackgroundImage")));
            this.pictureBox_paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_paste.Location = new System.Drawing.Point(577, 151);
            this.pictureBox_paste.Name = "pictureBox_paste";
            this.pictureBox_paste.Size = new System.Drawing.Size(24, 28);
            this.pictureBox_paste.TabIndex = 10;
            this.pictureBox_paste.TabStop = false;
            this.pictureBox_paste.Click += new System.EventHandler(this.pictureBox_paste_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.button_calc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_exit;
            this.ClientSize = new System.Drawing.Size(765, 246);
            this.Controls.Add(this.pictureBox_paste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_compare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.textBox_md5);
            this.Controls.Add(this.textBox_filesize);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.textBox_file);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件MD5码计算器";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_paste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_file;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_md5;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_compare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_filesize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.PictureBox pictureBox_paste;
    }
}

