using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.Utils
{
    public class PointXYZ
    {
        private double _X;
        public double X
        {
            get
            {
                return _X;
            }
            set
            {
                _X = value;
            }
        }

        private double _Y;
        public double Y
        {
            get
            {
                return _Y;
            }
            set
            {
                _Y = value;
            }
        }

        private double _Z;
        public double Z
        {
            get
            {
                return _Z;
            }
            set
            {
                _Z = value;
            }
        }
    }
}
