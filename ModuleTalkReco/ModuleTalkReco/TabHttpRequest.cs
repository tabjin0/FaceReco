using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ModuleTalkReco {
    public class TabHttpRequest {

        public static string GetLVTalkResult(string url, string data) {
            // utf-8编码
            var encoding = Encoding.GetEncoding("utf-8");
            byte[] buffer = encoding.GetBytes(data);
            // 根据lvURL创建HttpWebRequest对象
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "post";
            //request.Headers.Add("charset:utf-8");            
            request.ContentLength = buffer.Length;
            request.ContentType = "text/xml";

            StreamWriter myWriter = null;
            try {
                myWriter = new StreamWriter(request.GetRequestStream());
                myWriter.Write(data);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally {
                myWriter.Close();
            }
            //读取服务器返回的信息
            HttpWebResponse objResponse = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream())) {
                string result = string.Empty;
                result = sr.ReadToEnd();
                Console.WriteLine(result);
                Console.ReadLine();
                return result;
            }
        }
    }
}
