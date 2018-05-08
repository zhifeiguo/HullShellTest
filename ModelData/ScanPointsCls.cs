using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.ModelData
{
    public class ScanPointsCls
    {
        public ScanPointsCls()
        {
            SPList = new List<PointCls>();
        }

        private string _FileName;
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        public List<PointCls> SPList;

    }
}
