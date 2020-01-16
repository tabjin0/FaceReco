using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YunZhiFaceReco {
    public partial class LockScreenForm : Form {

        public string password;
        public LockScreenForm() {
            InitializeComponent();
            // 软件初始状态之下，屏蔽左"WIN"、右"Win" | 屏蔽Ctrl+Esc | 屏蔽Alt+f4  | 屏蔽Alt+Esc | 屏蔽Alt+Tab | 截获Ctrl+Shift+Esc | 截获Ctrl+Alt+Delete 
            Hook.Hook_Start();
            // 软件初始状态下默认禁用任务管理器，除非人脸识别成功之后才能打开任务管理器
            Hook.ShieldMissionTask(1);


            this.WindowState = FormWindowState.Maximized; // 窗体启动就最大化
        }
        public LockScreenForm(bool bl) //超时登录走这个
        {
            InitializeComponent();
            isTimer = bl;
        }

        /***************获取鼠标键盘未操作时间***************************/
        [StructLayout(LayoutKind.Sequential)]
        public struct LASTINPUTINFO {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwTime;
        }
        [DllImport("user32.dll")]
        public static extern bool GetLastInputInfo(ref    LASTINPUTINFO plii);


        public long getIdleTick() {
            LASTINPUTINFO vLastInputInfo = new LASTINPUTINFO();
            vLastInputInfo.cbSize = Marshal.SizeOf(vLastInputInfo);
            if (!GetLastInputInfo(ref    vLastInputInfo)) return 0;
            return Environment.TickCount - (long)vLastInputInfo.dwTime;
        }
        /***************获取鼠标键盘未操作时间***************************/

        public static bool isTimer = false;//判断是否是超时了
        private void Login_Load(object sender, EventArgs e) {
            this.timer1.Interval = 10000;//定时器，每10秒出发一次timer事件
            this.timer1.Enabled = true;//启动
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()) || string.IsNullOrEmpty(txtPwd.Text.Trim())) {
                MessageBox.Show("用户名或密码不能为空！");
                txtUser.Focus();
            }
            else {
                if (txtUser.Text.Trim() == "edit" && txtPwd.Text.Trim() == password)// 注意去掉前后的空格
                {
                    this.Hide();
                    if (isTimer == false)//正常登录
                    {
                        //FaceForm faceForm = new FaceForm(); //跳转
                        //faceForm.Show();
                        this.Hide();
                    }
                }
                else {
                    MessageBox.Show("用户名或密码错误！");
                    txtPwd.Text = "";
                    txtPwd.Focus();//获得焦点
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            txtUser.Text = "";
            txtPwd.Text = "";
        }

        /// <summary>
        /// keyDown判断是否是enter键，进行登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPwd_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return)//enter键 ==(char)13也可
            {
                btnLogin_Click(sender, e);//登录事件
            }
        }

        /// <summary>
        ///  计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            long i = getIdleTick();
            if (i > 600000 * 2)//目前判断是20分钟。超过一分钟是>=60000。十分钟600000。
            {
                //if (this.Visible==false)//如果已经弹出登录模式窗口的话，不弹出了。  
                //{
                //    FmLogin lmain = new FmLogin(true);//这个判断不管用
                //    lmain.ShowDialog();
                //}

                //  暂时注释掉
                /*
                bool isTrue = false;
                List<bool> listb = new List<bool>();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name.Trim() == "Login")
                    {
                        listb.Add(true);
                        if (listb.Count >= 2)
                        {
                            isTrue = true;
                        }
                    }
                }
                if (isTrue == false)//若未打开，表明已经打开
                {
                    LockScreenForm lmain = new LockScreenForm(true);
                    lmain.ShowDialog();
                }
                 */

                KillProcess("cmd");// 先关闭第三方大洋软件
                KillProcess("YunZhiFaceReco");// 这边直接关闭人脸识别软件是因为当前人员锁屏20分钟之后，认为其已经离开，关闭软件，进入下一个人员识别流程
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
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

        /// <summary>
        /// Tab键切换焦点 //有文本框textbox1和textbox2，现在光标在textbox1中，按回车键后怎样让光标跳至textbox2，
        /// 实现tab键的功能.首先设置textBox1和textBox2的TabIndex属性，分别设置为1，2。 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        SendKeys.Send("{Tab}");
        //    } 
        //}

    }
}
