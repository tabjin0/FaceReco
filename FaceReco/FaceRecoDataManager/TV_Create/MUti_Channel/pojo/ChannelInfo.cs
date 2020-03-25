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
        public string Id { get; set; }
        // 频道名
        public string Name { get; set; }
        //频道数据库表名
        public string DatabaseName { get; set; }
        // 频道数据库类型
        public int DatabaseType { get; set; }
        // 频道数据库密码
        public string DatabasePassword { get; set; }
        // 频道数据库名
        public string ServerName { get; set; }
        // 频道数据库用户名
        public string UserName { get; set; }
    }
}
