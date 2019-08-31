using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunZhiFaceReco
{
    public class Users
    {
        private string id;
        private string name;
        private string utoken;
        private string department;
        private byte[] feature;

        public byte[] Feature
        {
            get { return feature; }
            set { feature = value; }
        }
        private string createTime;

        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Utoken
        {
            get { return utoken; }
            set { utoken = value; }
        }
        
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}
