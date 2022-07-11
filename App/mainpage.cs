using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace ShouHelper
{
    public partial class loginPage : Form
    {
        /*定义函数*/
        public string verson ="1.0.0";
        public bool see_password =false;//密码可视
        public bool save_password = false;//保存密码
        public string updateInfo = "正在检查更新";
        public string settings_path = "settings.st";
        public string user_path = "user.st";
        public loginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e, string username)
        {
            //if (File.Exists(settings_path))
            File.Create("user_path");
            seePassword_pic.Image = ShouHelper.Properties.Resources.close_eye;
            textBox2.UseSystemPasswordChar = true;
            statusLED.Text = "正在连接";
            statusLED.Image = ShouHelper.Properties.Resources.banned;
            versonInfo.Text = "|版本号:"+verson+updateInfo + "|";
            tipsInfo.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            passwordBox.Image = ShouHelper.Properties.Resources.a1;
            usernameBox.Image = ShouHelper.Properties.Resources.b2;
            tipsInfo.Text = "请在框内输入兽时账户";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            passwordBox.Image = ShouHelper.Properties.Resources.a2;
            usernameBox.Image = ShouHelper.Properties.Resources.b1;
            tipsInfo.Text = "请在框内输入您的密码";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            seePassword_pic.Visible = true;
        }

        private void seePassword_pic_Click(object sender, EventArgs e)
        {
            if(see_password==false)
            {
                seePassword_pic.Image = ShouHelper.Properties.Resources.open_eye;
                textBox2.UseSystemPasswordChar = false;
                see_password = true;
            }
            else
            {
                seePassword_pic.Image = ShouHelper.Properties.Resources.close_eye;
                textBox2.UseSystemPasswordChar = true;
                see_password = false;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            usernameBox.Image = ShouHelper.Properties.Resources.b1;
            passwordBox.Image = ShouHelper.Properties.Resources.a1;
        }

        private void savepassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(save_password==false)
                {
                tipsInfo.Text = "下次将会自动登录";
                save_password = true;
                }
            else
            {
                tipsInfo.Text = "您已取消自动登录";
                save_password =false;
            }
        }
    }
}
