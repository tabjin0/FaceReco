using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunZhiFaceReco;
using YunZhiFaceReco.TV_Create.MUti_Channel.pojo;

namespace YunZhiFaceRecoDataManager.TV_Create.Interface {
    public interface IUser {
        List<UserInfos> QueryUserInfos(string _connectString);

        //User PriciseFindUserById(String id);

        List<User> FuzzyFindUserByName(String userName);
    }
}
