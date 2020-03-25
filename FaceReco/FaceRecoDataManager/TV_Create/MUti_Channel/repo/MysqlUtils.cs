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
using System.Configuration;


namespace YunZhiFaceReco {
    public class MysqlUtils {
        private MySqlConnection connection;
        private string server;
        private string db;
        private string uid;
        private string password;
        AppSettingsReader configuration = new AppSettingsReader();
        public MysqlUtils() {

            // 初始化连接
            this.server = (string)configuration.GetValue("MYSQL_SERVER_NAME", typeof(string));
            this.db = (string)configuration.GetValue("MYSQL_DATABASE", typeof(string));
            this.uid = (string)configuration.GetValue("MYSQL_UID", typeof(string));
            this.password = (string)configuration.GetValue("MYSQL_PASSWORD_NAME", typeof(string));
            this.Initialize();
        }

        #region 初始化、开关数据库
        private void Initialize() {

            string connectionString;
            connectionString = "SERVER=" + this.server + ";" + "DATABASE=" + this.db + ";" + "UID=" + this.uid + ";" + "PASSWORD=" + this.password + ";charset=utf8";

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
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("无法连接数据库");
                        break;

                    case 1045:
                        MessageBox.Show("无效的用户名或密码，请重试");
                        break;
                }
                return false;
            }
        }
        // 关闭连接
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
            string query = "INSERT INTO `face-reco`.`muti_channel` (`id`, `name`, `database_name`, `database_type`, `database_password`, `server_name`, `user_name`) VALUES (@id, @Name, @DatabaseName, @DatbaseType, @DatabasePassword, @ServerName, @UserName)";

            //open connection
            if (this.OpenConnection() == true) {
                //create command and assign the query and connection from the constructor
                using (MySqlCommand cmd = new MySqlCommand(query, connection)) {
                    // 参数插入
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = channelInfo.Id;
                    cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = channelInfo.Name;
                    cmd.Parameters.Add("@DatabaseName", MySqlDbType.VarChar).Value = channelInfo.DatabaseName;
                    cmd.Parameters.Add("@DatbaseType", MySqlDbType.Int16).Value = channelInfo.DatabaseType;
                    cmd.Parameters.Add("@DatabasePassword", MySqlDbType.VarChar).Value = channelInfo.DatabasePassword;
                    cmd.Parameters.Add("@ServerName", MySqlDbType.VarChar).Value = channelInfo.ServerName;
                    cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = channelInfo.UserName;

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
            //Open connection
            if (this.OpenConnection() == true) {
                // 创建命令
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // 读取数据
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 存储数据
                while (dataReader.Read()) {
                    ChannelInfo channelInfo = new ChannelInfo();
                    channelInfo.Id = Convert.ToString(dataReader["id"]);
                    channelInfo.Name = Convert.ToString(dataReader["name"]);
                    channelInfo.ServerName = Convert.ToString(dataReader["server_name"]);
                    channelInfo.DatabaseName = Convert.ToString(dataReader["database_name"]);
                    channelInfo.DatabaseType = Convert.ToInt32(dataReader["database_type"]);
                    channelInfo.UserName = Convert.ToString(dataReader["username"]);
                    channelInfo.DatabasePassword = Convert.ToString(dataReader["database_password"]);
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
            string query = "SELECT * FROM `face-reco`.`muti_channel` WHERE name = '" + channelName + "'";

            ChannelInfo channelInfo = new ChannelInfo();

            if (this.OpenConnection() == true) {
                // 创建命令
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // 读取数据
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // 存储数据
                while (dataReader.Read()) {
                    channelInfo.Id = Convert.ToString(dataReader["id"]);
                    channelInfo.Name = Convert.ToString(dataReader["name"]);
                    channelInfo.ServerName = Convert.ToString(dataReader["server_name"]);
                    channelInfo.DatabaseName = Convert.ToString(dataReader["database_name"]);
                    channelInfo.DatabaseType = Convert.ToInt32(dataReader["database_type"]);
                    channelInfo.UserName = Convert.ToString(dataReader["username"]);
                    channelInfo.DatabasePassword = Convert.ToString(dataReader["database_password"]);
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
