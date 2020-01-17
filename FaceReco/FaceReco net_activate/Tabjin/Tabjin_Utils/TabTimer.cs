using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunZhiFaceReco.Tabjin_Utils {
    public class TabTimer {
        public static string getDayOfWeek() {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];// 强制转为int
            return week;
        }

        public static string NowTime() {
            return DateTime.Now.ToString() + "   " + TabTimer.getDayOfWeek();
        }
    }
}
