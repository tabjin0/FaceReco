using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace ModuleTalkReco {
    class Program {
        static void Main(string[] args) {

            /* 
             string lvURL = "http://192.168.138.47:8081//LeoVideoAPI/service/addFileASRTask";
             */
            string lvURL = "http://www.baidu.com";

            // 拼装xml
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            strBuilder.Append("<AddFileASRTaskRequest>");
            strBuilder.Append("<UserID>DYMAM</UserID>");
            strBuilder.Append("<TaskID>AEE64245-6F59-5D78-4459-E3A91F343EAD</TaskID>");
            strBuilder.Append("<CallbackAddressInfo>http://192.168.138.65:18801/ASRTaskCallBack</CallbackAddressInfo>");
            strBuilder.Append("<TaskName>AudioCmdAnalze_AEE64245-6F59-5D78-4459-E3A91F343EAD</TaskName>");
            strBuilder.Append("<ResultIncludeTime>0</ResultIncludeTime>");
            strBuilder.Append("<IncludePunctuation>0</IncludePunctuation>");
            strBuilder.Append("<SourceFile><FileType>1</FileType><FileName>AudioStart.wav</FileName><PathInfo>M:\\打包公共区</PathInfo></SourceFile>");
            strBuilder.Append("</AddFileASRTaskRequest>");

            string data = strBuilder.ToString();
            //TabHttpRequest.GetLVTalkResult(lvURL, data);

            Process.Start(@"C:\Users\tabjin\AppData\Local\Google\Chrome\Application\chrome.exe", "https://www.baidu.com/s?wd=C%23%20%E6%89%93%E5%BC%80Chrome%E5%B8%A6%E5%9C%B0%E5%9D%80&rsv_spt=1&rsv_iqid=0xf04270210000d938&issp=1&f=8&rsv_bp=1&rsv_idx=2&ie=utf-8&rqlang=cn&tn=baiduhome_pg&rsv_enter=1&rsv_dl=tb&oq=c%2523%2520%25E6%2589%2593%25E5%25BC%2580chrome&inputT=21726&rsv_t=5093StDDmA8wGJaS4Q%2F74vRxy3HfB5Y%2BUmYKdTjmF4PscOt4%2BeJ5d5Fjgl2T3lp7HkoV&rsv_pq=8a815af30000d0ce&rsv_sug3=53&rsv_sug2=0&rsv_sug4=22462");
        }
    }
}
