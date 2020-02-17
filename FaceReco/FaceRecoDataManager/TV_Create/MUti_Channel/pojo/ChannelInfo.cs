using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunZhiFaceReco.TV_Create.MUti_Channel.pojo {
    /// <summary>
    /// 频道基础实体类
    /// </summary>
    public class ChannelInfo {
        public string channelId { get; set; }
        // 频道名
        public string channelName { get; set; }
        //频道数据库表名
        public string channelDatabaseName { get; set; }
        // 频道数据库类型
        public int channelDatabaseType { get; set; }
        // 频道数据库密码
        public string channelDatabasePassword { get; set; }
        // 频道数据库名
        public string channelServerName { get; set; }
        // 频道数据库用户名
        public string channelUserName { get; set; }
    }
}
