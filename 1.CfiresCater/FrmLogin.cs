using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CfiresCater.BLL;
using CfiresCater.Model;

namespace CfiresCater
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //登录
        private void button1_Click(object sender, EventArgs e)
        {
            //1.获取用户名和密码
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text;

            string msg = null;
            if (CheckEmpty(name, pwd))
            {
                UserInfoBLL bll = new UserInfoBLL();
                if (bll.GetUserByLoginName(name, pwd, out msg))
                {
                    //登录成功
                    msgDiv1.MsgDivShow(msg, 1, Bind);
                }
                else
                {
                    //登录失败
                    msgDiv1.MsgDivShow(msg, 1);

                }
            }
            else
            {

            }
            //2.判断用户名和密码不能为空

        }

        /// <summary>
        /// 判断用户名密码是否为空(均不为空返回True)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool CheckEmpty(string name, string pwd)
        {
            if (string.IsNullOrEmpty(name))
            {
                msgDiv1.MsgDivShow("用户名不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                msgDiv1.MsgDivShow("密码不能为空", 1);
                return false;
            }

            return true;
        }

        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 关闭登录窗口
        /// </summary>
        void Bind()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
