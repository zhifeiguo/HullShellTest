using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.ModelData
{
    public class DefectsListCls
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        //缺陷名
        private string _DefectName;
        public string DefectName
        {
            get { return _DefectName; }
            set { _DefectName = value; }
        }
        //缺陷原因
        private string _DefectReason;
        public string DefectReason
        {
            get { return _DefectReason; }
            set { _DefectReason = value; }
        }

        //Solution
        private string _Slution;
        public string Slution
        {
            get { return _Slution; }
            set { _Slution = value; }
        }
    }
}
