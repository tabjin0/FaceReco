using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoStartDaYang {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("666666666666666666666666666666666666666666666666666666");
    
            TabConsoleHelp.hideConsole();
            ProcessMng.startProcess("cmd", "C:\\Windows\\System32\\cmd.exe", "");
        }
    }
}
