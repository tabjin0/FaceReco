using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunZhiFaceReco;
using YunZhiFaceReco.TV_Create.MUti_Channel.pojo;
using YunZhiFaceReco.TV_Create.MUti_Channel.repo;
using YunZhiFaceRecoDataManager.TV_Create.Interface;

namespace YunZhiFaceRecoDataManager.TV_Create.MUti_Channel.model {
    public class UserInfo : IUser {
        public List<UserInfos> QueryUserInfos(string _connectString) {
            SQLServer_Connector sqlserver = new SQLServer_Connector(_connectString);
            return sqlserver.QueryUserInfos();
        }

        public List<User> FuzzyFindUserByName(String userName) {
            // Mysql
            MysqlUtils mysqlUtils = new MysqlUtils();
            return mysqlUtils.FuzzyFindUserByName("张进");
        }
    }
}
