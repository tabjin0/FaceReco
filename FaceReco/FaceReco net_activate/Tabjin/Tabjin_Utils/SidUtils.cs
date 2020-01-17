using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunZhiFaceReco
{
    class SidUtils
    {
        /// <summary>
        ///  生成唯一键
        /// </summary>
        /// <returns></returns>
        public static string sid()
        {
            System.Guid guid = new Guid();
            guid = Guid.NewGuid();
            string str = guid.ToString();
            return str;
        }
    }
}
