using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunZhiFaceReco.TV_Create.MUti_Channel.pojo;

namespace YunZhiFaceReco.TV_Create.MUti_Channel {
    public class Channel {
        /// <summary>
        /// 将新频道手动输入到人脸识别附属数据库
        /// </summary>
        /// <param name="channelInfo"></param>
        public void AddChannel(ChannelInfo channelInfo) {
            MysqlUtils mysqlUtils = new MysqlUtils();
            mysqlUtils.InsertTVCreateDBInfoToFaceRecoDB(channelInfo);
        }

        /// <summary>
        /// 批量获取多频道配置信息
        /// </summary>
        /// <returns></returns>
        public static List<ChannelInfo> QueryChannels() {
            MysqlUtils mysqlUtils = new MysqlUtils();
            return mysqlUtils.QueryChannels();
        }

        /// <summary>
        /// 精确获取多频道配置信息
        /// </summary>
        /// <param name="channelName">频道名称</param>
        /// <returns></returns>
        public static ChannelInfo QueryChannel(string channelName) {
            MysqlUtils mysqlUtils = new MysqlUtils();
            return mysqlUtils.PreciseQueryChannel(channelName);
        }
    }
}
