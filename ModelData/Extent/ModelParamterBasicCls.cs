using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.ModelData.Extent
{
    public class ModelParamterBasicCls
    {
        //加工次数
        private int _ProcessNumbers;
        public int ProcessNumbers
        {
            get { return _ProcessNumbers; }
            set { _ProcessNumbers = value; }
        }

        //环境温度
        private double _EnvTemperation;
        public double EnvTemperation
        {
            get { return _EnvTemperation; }
            set { _EnvTemperation = value; }
        }

        //记录时间
        private DateTime _RecordTime;
        public DateTime RecordTime
        {
            get { return _RecordTime; }
            set { _RecordTime = value; }
        }

        //系数
        private Double _Coefficient;
        public double Coefficient
        {
            get { return _Coefficient; }
            set { _Coefficient = value; }
        }

        //回弹量,此处取均值
        public double _ResilienceValue;
        public double ResilienceValue
        {
            get { return _ResilienceValue; }
            set { _ResilienceValue = value; }
        }

        //理论板名称
        private string _StdHullName;
        public string StdHullName
        {
            get { return _StdHullName; }
            set { _StdHullName = value; }
        }

        //作业人员姓名
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        //测量软件
        private string _SoftwareName;
        public string SoftwareName
        {
            get { return _SoftwareName; }
            set { _SoftwareName = value; }
        }

        //检测设备
        private string _DetectEquipmentName;
        public string DetectEquipmentName
        {
            get { return _DetectEquipmentName; }
            set { _DetectEquipmentName = value; }
        }

        //加工设备
        private string _ProcessEquipmentName;
        public string ProcessEquipmentName
        {
            get { return _ProcessEquipmentName; }
            set { _ProcessEquipmentName = value; }
        }

    }
}
