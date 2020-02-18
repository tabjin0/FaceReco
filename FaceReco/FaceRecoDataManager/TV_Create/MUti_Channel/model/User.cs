using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunZhiFaceReco.TV_Create.MUti_Channel.pojo;
using YunZhiFaceReco.TV_Create.MUti_Channel.repo;

namespace YunZhiFaceRecoDataManager.TV_Create.MUti_Channel.model {
    public class User {
        public static List<UserInfo> QueryUserInfos(string _connectString) {
            SQLServer_Connector sqlserver = new SQLServer_Connector(_connectString);
            return sqlserver.QueryUserInfos();
        }
    }
}
