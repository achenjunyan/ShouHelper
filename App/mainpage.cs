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
using System.Net;

namespace ShouHelper
{
    public partial class loginPage : Form
    {
        /*定义函数*/
        public string version = "1.0.0";
        public bool see_password = false;//密码可视
        public bool save_password = false;//保存密码
        public string settings_path = "settings.st";
        public string user_path = "user.st";
        string latestVersion;
        int errorcode = 4;//1连接成功，2需要更新，3连接失败，4异常错误（默认）
        public loginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e, string username)
        {
          
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
            if (see_password == false)
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
            if (save_password == false)
            {
                tipsInfo.Text = "下次将会自动登录";
                save_password = true;
            }
            else
            {
                tipsInfo.Text = "您已取消自动登录";
                save_password = false;
            }
        }

        public string GetInformFromServer(string path)//与网络api进行连接
        {
            //指定请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            //设置网络超时时间（不能过短，否则服务器来不及响应）
            request.Timeout = 1500;
            //得到返回
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //得到流
            Stream recStream = response.GetResponseStream();
            //编码方式
            Encoding gb2312 = Encoding.GetEncoding("UTF-8");
            //指定转换为gb2312编码
            StreamReader sr = new StreamReader(recStream, gb2312);
            //以字符串方式得到网页内容
            string content = sr.ReadToEnd();

            sr.Close();

            return content;

        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            //FileStream stWrite = new FileStream(settings_path, FileMode.Create);//读出user_path地址内的文件内容
            //FileStream stWrite2 = new FileStream(user_path, FileMode.Create);//读出user_path地址内的文件内容
            //File.Create("user_path");//创建一个文件，位置是user_path
            //StreamWriter sw = new StreamWriter("hello");
            //sw.WriteLine(user_path);
            //sw.Close();
            //stWrite.Close();
            try
            {
                latestVersion = GetInformFromServer("https://js.shoutime.cn/vrchat/version.php");
                if(latestVersion!=version)
                {
                    MessageBox.Show("您当前版本为:" + version + "最新版本为:" + latestVersion+"请及时更新客户端");
                    statusLED.Text = "已建立连接但需要更新";
                    errorcode = 2;
                    statusLED.Image = ShouHelper.Properties.Resources.loading;
                }
            }
            catch (Exception myex)
            {
                latestVersion = "";
                //MessageBox.Show("与服务器建立互联网失败");
                statusLED.Text = "无法访问服务器";
                errorcode = 3;
                statusLED.Image = ShouHelper.Properties.Resources.banned;
            }
            finally
            {
                if(errorcode!=3&&errorcode!=2&&errorcode!=4)
                {
                    errorcode = 1;
                    statusLED.Text = "连接成功";
                    statusLED.Image = ShouHelper.Properties.Resources.online;

                }
            }
            seePassword_pic.Image = ShouHelper.Properties.Resources.close_eye;
            textBox2.UseSystemPasswordChar = true;
            versonInfo.Text = "|客户端版本号:" + version+ "|";
            tipsInfo.Text = "";
    }
    }
}
