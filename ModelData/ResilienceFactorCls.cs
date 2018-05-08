using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.ModelData
{
    public class ResilienceFactorCls
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private double _ResilienCoefficient;
        public double ResilienCoefficient
        {
            get { return _ResilienCoefficient; }
            set { _ResilienCoefficient = value; }
        }

        private double _CurvatureRange;
        public double CurvatureRange
        {
            get { return _CurvatureRange; }
            set { _CurvatureRange = value; }
        }

        private double _WidthRange;
        public double WidthRange
        {
            get { return _WidthRange; }
            set { _WidthRange = value; }
        }

        private double _Curvature;
        public double Curvature
        {
            get { return _Curvature; }
            set { _Curvature = value; }
        }


    }
}
