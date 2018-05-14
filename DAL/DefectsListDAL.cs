using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.DAL
{
    public class DefectsListDAL
    {
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        private string _DefectName;
        public string DefectName
        {
            get
            {
                return _DefectName;
            }
            set
            {
                _DefectName = value;
            }
        }

        private string _DefectReason;
        public string DefectReason
        {
            get
            {
                return _DefectReason;
            }
            set
            {
                _DefectReason = value;
            }
        }

        private string _Solution;
        public string Solution
        {
            get
            {
                return _Solution;
            }
            set
            {
                _Solution = value;
            }
        }
    }
}
