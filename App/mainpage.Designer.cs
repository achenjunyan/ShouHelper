namespace ShouHelper
{
    partial class loginPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.versonInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tipsInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.savepassword_checkBox = new System.Windows.Forms.CheckBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.seePassword_pic = new System.Windows.Forms.PictureBox();
            this.statusLED = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.passwordBox = new System.Windows.Forms.PictureBox();
            this.usernameBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seePassword_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(185, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(185, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 30);
            this.textBox2.TabIndex = 7;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLED,
            this.versonInfo,
            this.tipsInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 887);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 31);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // versonInfo
            // 
            this.versonInfo.Name = "versonInfo";
            this.versonInfo.Size = new System.Drawing.Size(123, 24);
            this.versonInfo.Text = "版本更新提示|";
            // 
            // tipsInfo
            // 
            this.tipsInfo.Name = "tipsInfo";
            this.tipsInfo.Size = new System.Drawing.Size(82, 24);
            this.tipsInfo.Text = "操作提示";
            // 
            // savepassword_checkBox
            // 
            this.savepassword_checkBox.AutoSize = true;
            this.savepassword_checkBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.savepassword_checkBox.Location = new System.Drawing.Point(122, 416);
            this.savepassword_checkBox.Name = "savepassword_checkBox";
            this.savepassword_checkBox.Size = new System.Drawing.Size(164, 32);
            this.savepassword_checkBox.TabIndex = 11;
            this.savepassword_checkBox.Text = "下次自动登录";
            this.savepassword_checkBox.UseVisualStyleBackColor = true;
            this.savepassword_checkBox.CheckedChanged += new System.EventHandler(this.savepassword_checkBox_CheckedChanged);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(140, 588);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(325, 163);
            this.RichTextBox1.TabIndex = 12;
            this.RichTextBox1.Text = "";
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::ShouHelper.Properties.Resources.button1;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.loginButton.Location = new System.Drawing.Point(342, 409);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(204, 45);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // seePassword_pic
            // 
            this.seePassword_pic.Image = global::ShouHelper.Properties.Resources.open_eye;
            this.seePassword_pic.Location = new System.Drawing.Point(508, 345);
            this.seePassword_pic.Name = "seePassword_pic";
            this.seePassword_pic.Size = new System.Drawing.Size(27, 30);
            this.seePassword_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.seePassword_pic.TabIndex = 9;
            this.seePassword_pic.TabStop = false;
            this.seePassword_pic.Visible = false;
            this.seePassword_pic.Click += new System.EventHandler(this.seePassword_pic_Click);
            // 
            // statusLED
            // 
            this.statusLED.Image = global::ShouHelper.Properties.Resources.loading;
            this.statusLED.Name = "statusLED";
            this.statusLED.Size = new System.Drawing.Size(111, 24);
            this.statusLED.Text = "状态指示|";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ShouHelper.Properties.Resources.password;
            this.pictureBox6.Location = new System.Drawing.Point(137, 343);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ShouHelper.Properties.Resources.username;
            this.pictureBox5.Location = new System.Drawing.Point(137, 288);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.White;
            this.passwordBox.Image = global::ShouHelper.Properties.Resources.a1;
            this.passwordBox.Location = new System.Drawing.Point(122, 334);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(424, 51);
            this.passwordBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.White;
            this.usernameBox.Image = global::ShouHelper.Properties.Resources.b1;
            this.usernameBox.Location = new System.Drawing.Point(122, 280);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(424, 51);
            this.usernameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TabStop = false;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 918);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.savepassword_checkBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.seePassword_pic);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginPage";
            this.Text = "VRChat助手";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seePassword_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox usernameBox;
        private System.Windows.Forms.PictureBox passwordBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLED;
        private System.Windows.Forms.PictureBox seePassword_pic;
        private System.Windows.Forms.ToolStripStatusLabel versonInfo;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ToolStripStatusLabel tipsInfo;
        private System.Windows.Forms.CheckBox savepassword_checkBox;
        private System.Windows.Forms.RichTextBox RichTextBox1;
    }
}

