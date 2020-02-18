using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;
//Add MySql Library
using MySql.Data;
using MySql.Data.MySqlClient;
using YunZhiFaceReco.TV_Create.MUti_Channel.pojo;


namespace YunZhiFaceReco {
    public class MysqlUtils {
        private MySqlConnection connection;
        private string server;
        private string db;
        private string uid;
        private string password;
        public MysqlUtils() {
            // 初始化连接
            Initialize();
        }

        #region 初始化、开关数据库
        private void Initialize() {
            server = "localhost";
            db = "face-reco";
            uid = "root";
            password = "zj258025";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + db + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";charset=utf8";

            connection = new MySqlConnection(connectionString);
        }
        // 打开数据库连接
        //open connection to database
        private bool OpenConnection() {
            try {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        //Close connection
        private bool CloseConnection() {
            try {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region 人脸识别相关
        //Insert statement
        public void InsertUserFaceFeature(Users users) {
            string id = users.Id;
            string name = users.Name;
            string uToken = users.Utoken;
            string department = users.Department;
            //byte[] featureByte = users.Feature;

            string query = "INSERT INTO `face-reco`.`face`(`id`, `name`, `utoken`, `department`, `feature`) VALUES (@id, @name, @uToken,@department,@feature)";

            //open connection
            if (this.OpenConnection() == true) {
                //create command and assign the query and connection from the constructor
                using (MySqlCommand cmd = new MySqlCommand(query, connection)) {
                    // 参数插入
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@uToken", MySqlDbType.VarChar).Value = uToken;
                    cmd.Parameters.Add("@department", MySqlDbType.VarChar).Value = department;
                    cmd.Parameters.Add("@feature", MySqlDbType.MediumBlob).Value = users.Feature;
                    /*
                    MySqlParameter par = new MySqlParameter("@feature", MySqlDbType.Blob);
                    par.Value = users.Feature;
                    cmd.Parameters.Add(par);
                     */

                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("数据存储完成");

                    //close connection
                    this.CloseConnection();
                }
            }
        }

        public List<byte[]> SelectUserFaceByFeature() {
            string query = "SELECT `feature` FROM `face-reco`.`face`";// 全部查询

            // 创建list存储数据
            List<byte[]> list = new List<byte[]>();
            byte[] faceFeature = null;
            byte[] finalFaceFeature = null;

            //Open connection
            if (this.OpenConnection() == true) {
                // 创建命令
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // 读取数据
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 存储数据
                while (dataReader.Read()) {

                    faceFeature = TabConvert.ObjectToBytes(dataReader["feature"]);
                    finalFaceFeature = faceFeature.Skip(27).Take(1032).ToArray();// 从第5位开始截取3个字节
                    list.Add(finalFaceFeature);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else {
                return list;
            }
        }
        public byte[] PriciseSelectById(string id) {

            string query = "SELECT * FROM `face-reco`.`face` WHERE id='" + id + "'";

            // 创建list存储数据
            List<string> list = new List<string>();
            string str = "";
            byte[] feature = null;
            //Open connection
            if (this.OpenConnection() == true) {
                // 创建命令
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // 读取数据
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 存储数据
                while (dataReader.Read()) {
                    /*
                    str = dataReader["id"] + ","
                        + dataReader["name"] + ","
                        + dataReader["utoken"] + ","
                        + dataReader["department"] + ","
                        + dataReader["feature"] + ","
                        + dataReader["create_time"] + ",";
                     */
                    feature = (byte[])dataReader["feature"];
                    string[] strArray = str.Split(',');
                    list.Add(str);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return feature;
            }
            else {
                return feature;
            }
        }
        #endregion

        #region 电视文创中心数据库相关
        /// <summary>
        /// 手动导入电视文创中心的相关数据库信息，保存到人脸识别库中
        /// </summary>
        /// <param name="channelInfo"></param>
        public void InsertTVCreateDBInfoToFaceRecoDB(ChannelInfo channelInfo) {
            string query = "INSERT INTO `face-reco`.`muti_channel` (`id`, `channel_name`, `channel_database_name`, `channel_database_type`, `channel_database_password`, `channel_server_name`, `channel_user_name`) VALUES (@id, @channelName, @channelDatabaseName, @channelDatbaseType, @channelDatabasePassword, @channelServerName, @channelUserName)";

            //open connection
            if (this.OpenConnection() == true) {
                //create command and assign the query and connection from the constructor
                using (MySqlCommand cmd = new MySqlCommand(query, connection)) {
                    // 参数插入
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = channelInfo.channelId;
                    cmd.Parameters.Add("@channelName", MySqlDbType.VarChar).Value = channelInfo.channelName;
                    cmd.Parameters.Add("@channelDatabaseName", MySqlDbType.VarChar).Value = channelInfo.channelDatabaseName;
                    cmd.Parameters.Add("@channelDatbaseType", MySqlDbType.Int16).Value = channelInfo.channelDatabaseType;
                    cmd.Parameters.Add("@channelDatabasePassword", MySqlDbType.VarChar).Value = channelInfo.channelDatabasePassword;
                    cmd.Parameters.Add("@channelServerName", MySqlDbType.VarChar).Value = channelInfo.channelServerName;
                    cmd.Parameters.Add("@channelUserName", MySqlDbType.VarChar).Value = channelInfo.channelUserName;

                    //Execute command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("数据库信息新增完成！");

                    //close connection
                    this.CloseConnection();
                }
            }
        }

        /// <summary>
        /// 获取多频道的配置信息
        /// </summary>
        /// <returns></returns>
        public List<ChannelInfo> QueryChannels() {
            string query = "SELECT * FROM `face-reco`.`muti_channel`";// 全部查询

            List<ChannelInfo> channelInfoLift = new List<ChannelInfo>();
            // 创建list存储数据
            //List<byte[]> list = new List<byte[]>();
            //byte[] faceFeature = null;
            //byte[] finalFaceFeature = null;

            //Open connection
            if (this.OpenConnection() == true) {
                // 创建命令
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // 读取数据
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 存储数据
                while (dataReader.Read()) {
                    ChannelInfo channelInfo = new ChannelInfo();
                    channelInfo.channelId = Convert.ToString(dataReader["id"]);
                    channelInfo.channelName = Convert.ToString(dataReader["channel_name"]);
                    channelInfo.channelServerName = Convert.ToString(dataReader["channel_server_name"]);
                    channelInfo.channelDatabaseName = Convert.ToString(dataReader["channel_database_name"]);
                    channelInfo.channelDatabaseType = Convert.ToInt32(dataReader["channel_database_type"]);
                    channelInfo.channelUserName = Convert.ToString(dataReader["channel_user_name"]);
                    channelInfo.channelDatabasePassword = Convert.ToString(dataReader["channel_database_password"]);
                    channelInfoLift.Add(channelInfo);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed

            }
            return channelInfoLift;
        }

        /// <summary>
        /// 精确查找多频道配置信息
        /// </summary>
        /// <param name="channelName">多频道频道名</param>
        /// <returns></returns>
        public ChannelInfo PreciseQueryChannel(string channelName) {
            string query = "SELECT * FROM `face-reco`.`muti_channel` WHERE channel_name = '" + channelName + "'";

            ChannelInfo channelInfo = new ChannelInfo();

            if (this.OpenConnection() == true) {
                // 创建命令
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // 读取数据
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 存储数据
                while (dataReader.Read()) {
                    channelInfo.channelId = Convert.ToString(dataReader["id"]);
                    channelInfo.channelName = Convert.ToString(dataReader["channel_name"]);
                    channelInfo.channelServerName = Convert.ToString(dataReader["channel_server_name"]);
                    channelInfo.channelDatabaseName = Convert.ToString(dataReader["channel_database_name"]);
                    channelInfo.channelDatabaseType = Convert.ToInt32(dataReader["channel_database_type"]);
                    channelInfo.channelUserName = Convert.ToString(dataReader["channel_user_name"]);
                    channelInfo.channelDatabasePassword = Convert.ToString(dataReader["channel_database_password"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            return channelInfo;
        }
        #endregion
    }
}
