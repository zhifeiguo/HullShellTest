using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public PointCls(double a,double b,double c)
        {
            x = a;
            y = b;
            z = c;
        }

        public double x;
        public double y;
        public double z;
    }
}