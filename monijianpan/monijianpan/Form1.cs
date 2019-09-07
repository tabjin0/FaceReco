using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace monijianpan {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string pass = "test01";
            //Process p = Process.Start(@"D:\Bin\QQScLauncher.exe");
            //Process p = Process.Start(@"C:\Users\tabjin\Desktop\test2.txt");
            Process p = Process.Start(@"C:\Users\tabjin\Desktop\H3CLogin.exe");
            Thread.Sleep(1000);
            /*  第一个输入框 start */
            // 切换到第一个账户输入框
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(pass);
            /*  第一个输入框 end */

            /*  第二个输入框 start */
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("^a");
            SendKeys.SendWait("{BACKSPACE}");
            SendKeys.SendWait(pass);
            /*  第二个输入框 end */

            /* 回车键 */
            SendKeys.SendWait("{ENTER}");
            p.WaitForExit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            /*
              InputLanguageCollection ilc = InputLanguage.InstalledInputLanguages;
            foreach (InputLanguage il in ilc) {
                comboBox1.Items.Add(il.LayoutName);
            }
            comboBox1.SelectedIndex = InputLanguage.InstalledInputLanguages.IndexOf(InputLanguage.CurrentInputLanguage);
             */

        }
    }
}
