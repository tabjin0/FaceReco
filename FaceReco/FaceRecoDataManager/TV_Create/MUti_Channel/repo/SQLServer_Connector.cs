using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using YunZhiFaceReco.TV_Create.MUti_Channel.pojo;

namespace YunZhiFaceReco.TV_Create.MUti_Channel.repo {
    public class SQLServer_Connector {
        static string _connectString = "server=178.20.10.85;database=Net2Dynetmanage2019;uid=sa;pwd=lq612176()";

        public SQLServer_Connector(string connStr) {
            _connectString = connStr;
        }

        #region 打开数据库
        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <returns></returns>
        //public bool OpenDataBase() {
        //    try {
        //        //创建数据库连接对象
        //        using (SqlConnection sqlConn = new SqlConnection(SQLServer_Connector._connectString)) {
        //            //打开连接
        //            sqlConn.Open();
        //            sqlConn.Close();
        //            return true;
        //        }
        //    }
        //    catch {
        //        return false;
        //    }
        //}
        #endregion

        #region 查找 ok 实际上多频道数据库仅仅是查询即可
        /// <summary>
        /// 根据用户唯一ID查找用户信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        //public static UserInfo query(String uid) {
        //    UserInfo userInfo = null;
        //    if (uid.Length != 0) {
        //        //后面拼写查询语句要用到窗体的信息
        //        SqlConnection con = new SqlConnection(SQLServer_Connector._connectString); //创建数据库连接类的对象
        //        con.Open(); //将连接打开
        //        SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
        //        //把输入的数据拼接成sql语句，并交给cmd对象
        //        //cmd.CommandText = "select*from users where name='" + user + "'and pwd='" + pwd + "'";
        //        cmd.CommandText = "select * from UserInfo where strUserID='" + uid + "'";

        //        //用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        var jsonStr = SQLServer_Connector.toJSONStr(dr);
        //        userInfo = JsonConvert.DeserializeObject<UserInfo>(jsonStr);
        //        con.Close();//用完后关闭连接，以免影响其他程序访问
        //    }
        //    if (userInfo == null) {
        //        MessageBox.Show("抱歉，未查询到用户！");
        //    }
        //    return userInfo;
        //}
        #endregion

        /// <summary>
        /// 根据用户唯一ID查找用户信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public List<UserInfos> QueryUserInfos() {
            List<UserInfos> userInfoList = new List<UserInfos>();

            //后面拼写查询语句要用到窗体的信息
            SqlConnection con = new SqlConnection(SQLServer_Connector._connectString); //创建数据库连接类的对象
            con.Open(); //将连接打开
            SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
            //把输入的数据拼接成sql语句，并交给cmd对象
            //cmd.CommandText = "select*from users where name='" + user + "'and pwd='" + pwd + "'";
            cmd.CommandText = "select * from UserInfo";

            //用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                UserInfos userInfo = new UserInfos();
                userInfo.strWorkCode = Convert.ToString(dr["strWorkCode"]);
                userInfo.strName = Convert.ToString(dr["strName"]);
                userInfo.strPassword = Convert.ToString(dr["strPassword"]);
                userInfo.dwOrigin = Convert.ToInt16(dr["dwOrigin"]);
                userInfo.strMobilePhone = Convert.ToString(dr["strMobilePhone"]);
                userInfo.strTelephone = Convert.ToString(dr["strTelephone"]);
                userInfo.strEmailAddress = Convert.ToString(dr["strEmailAddress"]);
                userInfo.pbIcon = Convert.ToString(dr["pbIcon"]);
                userInfo.enumUserStatus = Convert.ToInt16(dr["enumUserStatus"]);
                userInfo.strHint = Convert.ToString(dr["strHint"]);
                userInfoList.Add(userInfo);
            }

            if (userInfoList.Count == 0) {
                MessageBox.Show("抱歉，未查询到用户！");
            }
            MessageBox.Show("返回数据");
            return userInfoList;
        }

        #region 添加数据
        //public void add() {
        //    string MyConn = "server=127.0.0.1;uid=user;pwd=123456;database=Northwind;Trusted_Connection=no";
        //    SqlConnection MyConnection = new SqlConnection(MyConn);
        //    string MyInsert = "insert into Categories(CategoryName, Description)values('" + Convert.ToString(TextBox2.Text) + "','" + Convert.ToString(TextBox3.Text) + "')";
        //    SqlCommand MyCommand = new SqlCommand(MyInsert, MyConnection);
        //    try//异常处理
        //    {
        //        MyConnection.Open();
        //        MyCommand.ExecuteNonQuery();
        //        MyConnection.Close();
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine("{0} Exception caught.", ex);
        //    }
        //}
        #endregion

        #region 修改数据
        //public void update() {
        //    string categoryName = TextBox2.Text;
        //    string categoryDescription = TextBox3.Text;
        //    string MyConn = "server=127.0.0.1;uid=user;pwd=123456;database=Northwind;Trusted_Connection=no";
        //    SqlConnection MyConnection = new SqlConnection(MyConn);
        //    string MyUpdate = "Update Categories set CategoryName='" + categoryName + "',Description='" + categoryDescription + "' where CategoryID=" + TextBox1.Text;
        //    SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
        //    try {
        //        MyConnection.Open();
        //        MyCommand.ExecuteNonQuery();
        //        MyConnection.Close();
        //        TextBox1.Text = "";
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine("{0} Exception caught.", ex);
        //    }
        //}
        #endregion

        #region 删除数据
        //public void delete() {
        //    string MyConn = "server=127.0.0.1;uid=user;pwd=123456;database=Northwind;Trusted_Connection=no";
        //    SqlConnection MyConnection = new SqlConnection(MyConn);
        //    string MyDelete = "Delete from Categories where CategoryID=" + TextBox1.Text;
        //    SqlCommand MyCommand = new SqlCommand(MyDelete, MyConnection);
        //    try {
        //        MyConnection.Open();
        //        MyCommand.ExecuteNonQuery();
        //        MyConnection.Close();
        //        TextBox1.Text = "";
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine("{0} Exception caught.", ex);
        //    }
        //}
        #endregion

        public static string toJSONStr(SqlDataReader o) {
            StringBuilder s = new StringBuilder();
            //s.Append("[");
            if (o.HasRows)
                while (o.Read())
                    s.Append("{" + '"' + "strUserID" + '"' + ":" + '"' + o["strUserID"] + '"' + ", "
                    + '"' + "strWorkCode" + '"' + ":" + '"' + o["strWorkCode"] + '"' + ", "
                    + '"' + "strName" + '"' + ":" + '"' + o["strName"] + '"' + ","
                    + '"' + "strPassword" + '"' + ":" + '"' + o["strPassword"] + '"' + ","
                    + '"' + "dwOrigin" + '"' + ":" + o["dwOrigin"] + ","
                    + '"' + "strMobilePhone" + '"' + ":" + '"' + o["strMobilePhone"] + '"' + ","
                    + '"' + "strTelephone" + '"' + ":" + '"' + o["strTelephone"] + '"' + ","
                    + '"' + "strEmailAddress" + '"' + ":" + '"' + o["strEmailAddress"] + '"' + ","
                    + '"' + "dwVerifyMode" + '"' + ":" + o["dwVerifyMode"] + ","
                    + '"' + "pbIcon" + '"' + ":" + '"' + o["pbIcon"] + '"' + ","
                    + '"' + "enumUserStatus" + '"' + ":" + o["enumUserStatus"] + ","
                    + '"' + "odtUpdateDate" + '"' + ":" + '"' + o["odtUpdateDate"] + '"' + ","
                     + '"' + "odtCreateDate" + '"' + ":" + '"' + o["odtCreateDate"] + '"' + ","
                      + '"' + "strHint" + '"' + ":" + '"' + o["strHint"] + '"' + ","
                       + '"' + "strAttriReserved1" + '"' + ":" + '"' + o["strAttriReserved1"] + '"' + ","
                        + '"' + "strAttriReserved2" + '"' + ":" + '"' + o["strAttriReserved2"] + '"' + ","
                        + '"' + "strAttriReserved3" + '"' + ":" + '"' + o["strAttriReserved3"] + '"' + ","
                        + '"' + "strAttriReserved4" + '"' + ":" + '"' + o["strAttriReserved4"] + '"' + ","
                        + '"' + "strAttriReserved5" + '"' + ":" + '"' + o["strAttriReserved5"] + '"' + ","
                        + '"' + "strAttriReserved6" + '"' + ":" + '"' + o["strAttriReserved6"] + '"' + ","
                        + '"' + "strAttriReserved7" + '"' + ":" + '"' + o["strAttriReserved7"] + '"' + ","
                        + '"' + "strAttriReserved8" + '"' + ":" + '"' + o["strAttriReserved8"] + '"' + ","
                    + '"' + "strAttriReserved9" + '"' + ":" + '"' + o["strAttriReserved9"] + '"' + "}, ");
            s.Remove(s.Length - 2, 2);
            //s.Append("]");
            o.Close();
            return s.ToString();
        }
    }
}