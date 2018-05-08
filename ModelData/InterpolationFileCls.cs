using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.ModelData
{
    public class InterpolationFileCls
    {
        public InterpolationFileCls()
        {
            InterpolationList = new List<HeightValuesCls>();
        }

        private string _FileName;
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        public List<HeightValuesCls> InterpolationList;

    }
}
