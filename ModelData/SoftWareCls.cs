using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData
{
    public class SoftWareCls
    {
        private int _Id;
        [DisplayName("序号")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _SoftWareName;
        [DisplayName("软件名称")]
        public string SoftWareName
        {
            set { _SoftWareName = value; }
            get { return _SoftWareName; }
        }

        private string _RegisterAlgorithm;
        [DisplayName("配准算法")]
        public string RegisterAlgorithm
        {
            set { _RegisterAlgorithm = value; }
            get { return _RegisterAlgorithm; }
        }

        private string _DiffComputer;
        [DisplayName("偏差计算")]
        public string DiffComputer
        {
            set { _DiffComputer = value; }
            get { return _DiffComputer; }
        }

        private string _SurfaceReconstruction;
          [DisplayName("曲面重构方法")]
        public string SurfaceReconstruction
        {
            set { _SurfaceReconstruction = value; }
            get { return _SurfaceReconstruction; }
        }


    }
}
