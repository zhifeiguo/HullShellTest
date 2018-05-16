using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData
{
    public class PointCls
    {
        public PointCls()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public PointCls(double a, double b, double c)
        {
            x = a;
            y = b;
            z = c;
        }

        private double _x;
        [DisplayName("X")]
        public double x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        private double _y;
        [DisplayName("Y")]
        public double y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        private double _z;
        [DisplayName("Z")]
        public double z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }
    }
}
