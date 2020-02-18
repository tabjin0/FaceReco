using Regedit_Learn.initUser.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Regedit_Learn.TabInterface.database {
    public interface IChannelUser {
        RegisterInfo queryUserMutiDBInfo(String channelName);
    }

    class ChannelUserImpl : IChannelUser {
        public RegisterInfo queryUserMutiDBInfo(String channelName) {

            return null;
        }
    }
}
