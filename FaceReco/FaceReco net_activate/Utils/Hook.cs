using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace YunZhiFaceReco {
    public class Hook : IDisposable {
        //委托 
        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        static int hHook = 0;
        public const int WH_KEYBOARD_LL = 13;

        //LowLevel键盘截获，如果是WH_KEYBOARD＝2，并不能对系统键盘截取，Acrobat Reader会在你截取之前获得键盘。 
        static HookProc KeyBoardHookProcedure;

        //键盘Hook结构函数 
        [StructLayout(LayoutKind.Sequential)]
        public class KeyBoardHookStruct {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        #region [DllImport("user32.dll")]
        //设置钩子 
        [DllImport("user32.dll")]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        //抽掉钩子 
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);
        //调用下一个钩子 
        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);
        #endregion

        #region 安装键盘钩子
        /// <summary>
        /// 安装键盘钩子
        /// </summary>
        public static void Hook_Start() {
            // debug
            MessageBox.Show("Hook，安装键盘钩子成功");
            if (hHook == 0) {
                KeyBoardHookProcedure = new HookProc(KeyBoardHookProc);
                hHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyBoardHookProcedure,
                        GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
                //如果设置钩子失败. 
                if (hHook == 0)
                    Hook_Clear();
            }
        }
        #endregion

        #region 取消钩子事件
        /// <summary>
        /// 取消钩子事件
        /// </summary>
        public static void Hook_Clear() {
            // debug
            MessageBox.Show("Hook，取消键盘钩子");
            bool retKeyboard = true;
            if (hHook != 0) {
                retKeyboard = UnhookWindowsHookEx(hHook);
                hHook = 0;
            }
        }
        #endregion


        #region 屏蔽键盘
        /// <summary>
        /// 屏蔽键盘
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public static int KeyBoardHookProc(int nCode, int wParam, IntPtr lParam) {
            // debug
            MessageBox.Show("Hook，屏蔽键盘");
            if (nCode >= 0) {
                KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));
                // 屏蔽左"WIN"、右"Win"
                if ((kbh.vkCode == (int)Keys.LWin) || (kbh.vkCode == (int)Keys.RWin))
                    return 1;
                //屏蔽Ctrl+Esc
                if (kbh.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Control)
                    return 1;
                //屏蔽Alt+f4 
                if (kbh.vkCode == (int)Keys.F4 && (int)Control.ModifierKeys == (int)Keys.Alt)
                    return 1;
                //屏蔽Alt+Esc
                if (kbh.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Alt)
                    return 1;
                //屏蔽Alt+Tab 
                if (kbh.vkCode == (int)Keys.Tab && (int)Control.ModifierKeys == (int)Keys.Alt)
                    return 1;
                //截获Ctrl+Shift+Esc 
                if (kbh.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Shift)
                    return 1;
                //截获Ctrl+Alt+Delete 
                if ((int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt + (int)Keys.Delete)
                    return 1;
            }
            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }
        #endregion

        #region 是否屏蔽CTRL+ALT+DEL
        /// <summary>
        /// 是否屏蔽CTRL+ALT+DEL  OK正常
        /// 通过注册表的方式修改任务管理器的开关
        /// </summary>
        /// <param name="i">1=屏蔽 0=取消屏蔽</param>
        public static void ShieldMissionTask(int i) {
            // debug
            MessageBox.Show("Hook，屏蔽任务管理器");
            try {
                RegistryKey key = Registry.CurrentUser;
                RegistryKey key1 = key.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                key1.SetValue("DisableTaskMgr", i, Microsoft.Win32.RegistryValueKind.DWord);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose() {
            Hook_Clear();
        }
    }
}
