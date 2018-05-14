using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.Utils
{
    public class PointXYZRGB : PointXYZ
    {
        private int _R;
        public int R
        {
            get
            {
                return _R;
            }
            set
            {
                _R = value;
            }
        }

        private int _G;
        public int G
        {
            get
            {
                return _G;
            }
            set
            {
                _G = value;
            }
        }

        private int _B;
        public int B
        {
            get
            {
                return _B;
            }
            set
            {
                _B = value;
            }
        }

        private int _L;
        public int L
        {
            get
            {
                return _L;
            }
            set
            {
                _L = value;
            }
        }
    }
}
