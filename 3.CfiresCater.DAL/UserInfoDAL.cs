using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using CfiresCater.Model;

namespace CfiresCater.DAL
{
    public class UserInfoDAL
    {
        
        /// <summary>
        /// 根据用户账号查询用户信息
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public UserInfo GetUserByLoginName(string loginName)
        {
            string sql = "select * from UserInfo where LoginUserName=@LoginUserName and DelFlag=0";

            DataTable dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@LoginUserName", loginName));

            UserInfo user = null;
            if (dt.Rows.Count > 0)
            {
                user = RowToUserInfo(dt.Rows[0]);
            }

            return user;

        }

        /// <summary>
        /// 关系转对象  
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private UserInfo RowToUserInfo(DataRow dr)
        {
            UserInfo user = new UserInfo();
            user.LastLoginIp = dr["LastLoginIp"].ToString();
            user.LastLoginTime = Convert.ToDateTime(dr["LastLoginTime"]);
            user.LoginUserName = dr["LoginUserName"].ToString();
            user.Pwd = dr["Pwd"].ToString();
            user.UserName = dr["UserName"].ToString();
            user.SubTime = Convert.ToDateTime(dr["SubTime"]);
            user.UserId = Convert.ToInt32(dr["UserId"]);

            return user;
        }
    }
}
