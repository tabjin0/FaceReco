using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testRegeditAutoRun {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //获取当前应用程序的路径
            string localPath = Application.ExecutablePath;
            Hook.AutoRun();
            //Hook.RunWhenStart(true, "con", @"D:\Typora\Typora.exe");
        }
    }
}
