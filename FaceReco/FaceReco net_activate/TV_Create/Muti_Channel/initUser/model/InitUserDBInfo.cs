using Regedit_Learn.initUser.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regedit_Learn.initUser.model {
    public class InitUserDBInfo {
        #region 切换用户对应的数据库信息
        /// <summary>
        /// 根据频道设置注册表信息
        /// </summary>
        /// <param name="sWhichChannel"></param>
        /// <returns></returns>
        public static RegisterInfo init(String sWhichChannel) {
            // 本地数据库uuid -> 本地数据库标识 -> 用户数据库表中拿到该用户对应的多媒体频道配置

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
                case "测试数据库":
                    registerInfo.serverName = "178.20.10.85";
                    registerInfo.databaseName = "Net2Dynetmanage2019";
                    registerInfo.databaseType = 00000001;
                    registerInfo.userName = "sa";
                    registerInfo.password = "lq612176()";
                    break;
                default:
                    break;
            }
            return registerInfo;
        }
        #endregion

    }
}
