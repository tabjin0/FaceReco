using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regedit_Learn.initUser.pojo {
    public class RegisterInfo {
        public string serverName { set; get; }
        public long databaseType { set; get; }
        public string databaseName { set; get; }
        public string userName { set; get; }
        public string password { set; get; }

        public RegisterInfo(string _serverName, string _databaseName, string _userName, string _password, long _databaseType = 00000001) {
            serverName = _serverName;
            databaseName = _databaseName;
            userName = _userName;
            password = _password;
            databaseType = _databaseType;
        }

        public RegisterInfo() {
            // TODO: Complete member initialization
        }
    }
}
