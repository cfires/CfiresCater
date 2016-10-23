using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CfiresCater.Model;
using CfiresCater.DAL;

namespace CfiresCater.BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL dal = new UserInfoDAL();

        public bool GetUserByLoginName(string loginName, string pwd, out string msg)
        {
            bool flag = false;
            UserInfo user = dal.GetUserByLoginName(loginName);

            if (user != null)
            {
                if (user.Pwd == pwd)
                {
                    msg = "登录成功";
                    flag = true;
                }
                else
                {
                    msg = "用户名或密码错误";
                }
            }
            else
            {
                msg = "用户名不存在";
            }

            return flag;
        }
    }
}
