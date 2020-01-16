using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace YunZhiFaceReco {
    public class ProcessMng {
        /// <summary>
        /// 打开进程
        /// </summary>
        public static void startProcess() {
            // 判断进程是否存在
            Process[] ps = Process.GetProcessesByName("cmd");
            if (ps.Length > 0)// 进程存在
            {
                foreach (Process p in ps)
                    continue;
            }
            else// 进程不存在
            {
                // 打开外部exe
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Windows\System32\cmd.exe");
                //ProcessStartInfo info = new ProcessStartInfo(@"C:\DaYang\bin\D-Cube-EditU.exe");
                info.UseShellExecute = true;
                info.Verb = "runas";
                Process.Start(info);
            }
        }

        /// <summary>
        ///  关闭进程
        /// </summary>
        /// <param name="strProcessesByName"></param>
        public static void KillProcess(string strProcessesByName) {
            try {
                //可能存在进程名相同的进程
                foreach (Process process in Process.GetProcessesByName(strProcessesByName))
                    process.Kill();
            }
            catch (Exception ex) {
            }
        }
    }
}
