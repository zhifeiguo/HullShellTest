using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using HullShellTest.ModelData.Extent;

namespace HullShellTest.ModelData
{
    public class StdHullShellCls
    {

        public StdHullShellCls()
        {
            tpc = new TheoryPointsCls();
            Dir=new PointCls();
            Pt_Min = new PointCls();
            Pt_Max = new PointCls();

            StdHullBasicInfo = new StdHullBasicInformationCls();
        }

        //曲板基本信息
        public StdHullBasicInformationCls StdHullBasicInfo;

        //理论点云
        public TheoryPointsCls tpc;

        //包围盒
        public PointCls Dir;
        public PointCls Pt_Min;
        public PointCls Pt_Max;

        //回弹值
        public ResilienceFactorCls rfc;

    }
}
