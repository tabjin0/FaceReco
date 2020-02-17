using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunZhiFaceReco
{
    public class FaceFeature
    {
        private IntPtr feature;

        public IntPtr Feature
        {
            get { return feature; }
            set { feature = value; }
        }

        private int featureSize;

        public int FeatureSize
        {
            get { return featureSize; }
            set { featureSize = value; }
        }
    }
}
