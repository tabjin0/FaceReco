using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YunZhiFaceReco
{
    public class Param
    {
        private object sender;

        public object Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        private PaintEventArgs paintEventArgs;

        public PaintEventArgs PaintEventArgs
        {
            get { return paintEventArgs; }
            set { paintEventArgs = value; }
        }
        private EventArgs eventArgs;

        public EventArgs EventArgs
        {
            get { return eventArgs; }
            set { eventArgs = value; }
        }

       
    }
}
