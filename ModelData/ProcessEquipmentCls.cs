using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData
{
    public class ProcessEquipmentCls
    {
        //序号
        private int _Id;
        [DisplayName("序号")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        //加工设备名称
        private string _ProcessEquipmentName;
        [DisplayName("加工设备名称")]
        public string ProcessEquipmentName
        {
            get { return _ProcessEquipmentName; }
            set { _ProcessEquipmentName = value; }
        }

        //压头长度
        private int _PressureHeadLength;
        [DisplayName("压头尺寸")]
        public int PressureHeadLength
        {
            get { return _PressureHeadLength; }
            set { _PressureHeadLength = value; }
        }

        //驱动模式
        private string _DirverMode;
        [DisplayName("驱动方式")]
        public string DirverMode
        {
            get { return _DirverMode; }
            set { _DirverMode = value; }
        }

        //下模压头数目
        private int _DownDieHeadNumber;
        [DisplayName("下模压头数目")]
        public int DownDieHeadNumber
        {
            get { return _DownDieHeadNumber; }
            set { _DownDieHeadNumber = value; }
        }

        //上模压头数目
        private int _UpDieHeadNumber;
        [DisplayName("上模压头数目")]
        public int UpDieHeadNumber
        {
            get { return _UpDieHeadNumber; }
            set { _UpDieHeadNumber = value; }
        }

    }
}
