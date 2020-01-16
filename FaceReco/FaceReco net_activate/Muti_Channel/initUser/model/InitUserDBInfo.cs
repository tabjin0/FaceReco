using Regedit_Learn.initUser.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regedit_Learn.initUser.model {
    public class InitUserDBInfo {
        #region 切换用户对应的数据库信息
        public static RegisterInfo init(String sWhichChannel) {
            RegisterInfo registerInfo = new RegisterInfo();
            switch (sWhichChannel) {
                case "城市高清网":
                    registerInfo.serverName = "192.168.138.45";
                    registerInfo.databaseName = "";
                    registerInfo.databaseType = 00000001;
                    registerInfo.userName = "sa";
                    registerInfo.password = "1100110";
                    break;
                case "生活高清网":
                    registerInfo.serverName = "192.168.138.140";
                    registerInfo.databaseName = "";
                    registerInfo.databaseType = 00000001;
                    registerInfo.userName = "sa";
                    registerInfo.password = "1100110";
                    break;
                default:
                    break;
            }
            return registerInfo;
        }
        #endregion
        
    }
}
