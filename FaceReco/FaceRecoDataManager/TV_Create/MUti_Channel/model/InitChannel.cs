using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunZhiFaceReco.TV_Create.MUti_Channel.pojo;

namespace YunZhiFaceReco.TV_Create.MUti_Channel {
    public class InitChannel {
        /// <summary>
        /// 将新频道手动输入到人脸识别附属数据库
        /// </summary>
        /// <param name="channelInfo"></param>
        public void AddChannel(ChannelInfo channelInfo) {
            MysqlUtils mysqlUtils = new MysqlUtils();
            mysqlUtils.InsertTVCreateDBInfoToFaceRecoDB(channelInfo);
        }

        public static ChannelInfo QueryChannels() {
            MysqlUtils mysqlUtils = new MysqlUtils();
            return mysqlUtils.QueryChannels();
        }
    }
}
