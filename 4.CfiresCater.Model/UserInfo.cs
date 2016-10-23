using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfiresCater.Model
{
    public class UserInfo
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string LoginUserName { get; set; }

        public string Pwd { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public string LastLoginIp { get; set; }

        public int DelFlag { get; set; }

        public DateTime? SubTime { get; set; }

    }
}
