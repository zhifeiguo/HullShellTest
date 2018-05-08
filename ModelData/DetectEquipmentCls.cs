using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData
{
    public class DetectEquipmentCls
    {
        //序号Id
        private int _Id;
        [DisplayName("序号")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        //测量设备名称
        private string _MeasureDeviceName;
        [DisplayName("设备名称")]
        public string MeasureDeviceName
        {
            get { return _MeasureDeviceName; }
            set { _MeasureDeviceName = value; }
        }

        //相机分辨率
        private string _CameraResolution;
        [DisplayName("相机分辨率")]
        public string CameraResolution
        {
            get { return _CameraResolution; }
            set { _CameraResolution = value; }
        }

        //像素尺寸
        private string _PixelSize;
        [DisplayName("像素尺寸")]
        public string PixelSize
        {
            get { return _PixelSize; }
            set { _PixelSize = value; }
        }

        //设备理论精度
        private double _StdPrecision;
        [DisplayName("设备理论精度")]
        public double StdPrecision
        {
            get { return _StdPrecision; }
            set { _StdPrecision = value; }
        }
    }
}
