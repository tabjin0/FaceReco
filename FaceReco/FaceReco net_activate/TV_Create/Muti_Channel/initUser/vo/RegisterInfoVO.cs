using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regedit_Learn.initUser.vo {
    public class RegisterInfoVO {
        public string serverName { set; get; }
        public long databaseType { set; get; }
        public string databaseName { set; get; }
        public string userName { set; get; }
        public string password { set; get; }
        public string uuid { set; get; }
    }
}
