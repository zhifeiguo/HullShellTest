using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.ModelData.Extent
{
    public class PtsCloud
    {
        public PtsCloud()
        {
            PtsCls = new List<PointCls>();
        }

        public List<PointCls> PtsCls;
    }
}
