using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.ModelData
{
    public class AdjustShapeFileCls
    {
        public AdjustShapeFileCls()
        {
            HeightValuesList = new List<HeightValuesCls>();
        }

        //文件名
        private string _FileName;
        public string FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
            }
        }

        //原始调形数据
        public List<HeightValuesCls> HeightValuesList;
    }
}
