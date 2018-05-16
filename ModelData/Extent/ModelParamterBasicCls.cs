using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData.Extent
{
    public class ModelParamterBasicCls
    {
        //索引
        private int _Id;
        [DisplayName("索引")]
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

        //加工次数
        private int _ProcessNumbers;
        [DisplayName("加工次数")]
        public int ProcessNumbers
        {
            get
            {
                return _ProcessNumbers;
            }
            set
            {
                _ProcessNumbers = value;
            }
        }

        //环境温度
        private double _EnvTemperation;
        [DisplayName("环境温度")]
        public double EnvTemperation
        {
            get
            {
                return _EnvTemperation;
            }
            set
            {
                _EnvTemperation = value;
            }
        }

        //记录时间
        private DateTime _RecordTime;
        [DisplayName("记录时间")]
        public DateTime RecordTime
        {
            get
            {
                return _RecordTime;
            }
            set
            {
                _RecordTime = value;
            }
        }

        //系数
        private Double _Coefficient;
        [DisplayName("逼近系数")]
        public double Coefficient
        {
            get
            {
                return _Coefficient;
            }
            set
            {
                _Coefficient = value;
            }
        }

        //回弹量,此处取均值
        public double _ResilienceValue;
        [DisplayName("回弹值")]
        public double ResilienceValue
        {
            get
            {
                return _ResilienceValue;
            }
            set
            {
                _ResilienceValue = value;
            }
        }

        //理论板名称
        private string _StdHullName;
        [DisplayName("理论板名称")]
        public string StdHullName
        {
            get
            {
                return _StdHullName;
            }
            set
            {
                _StdHullName = value;
            }
        }

        //作业人员姓名
        private string _UserName;
        [DisplayName("作业人员姓名")]
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        //测量软件
        private string _SoftwareName;
      [DisplayName("测量软件")]
        public string SoftwareName
        {
            get
            {
                return _SoftwareName;
            }
            set
            {
                _SoftwareName = value;
            }
        }

        //检测设备
        private string _DetectEquipmentName;
        [DisplayName("检测设备")]
        public string DetectEquipmentName
        {
            get
            {
                return _DetectEquipmentName;
            }
            set
            {
                _DetectEquipmentName = value;
            }
        }

        //加工设备
        private string _ProcessEquipmentName;
        [DisplayName("加工设备")]
        public string ProcessEquipmentName
        {
            get
            {
                return _ProcessEquipmentName;
            }
            set
            {
                _ProcessEquipmentName = value;
            }
        }
    }
}
