using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData.Extent
{
    public class StdHullBasicInformationCls
    {
        private int _Id;
        [DisplayName("序号")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _PlateModel;
        [DisplayName("曲板名称")]
        public string PlateModel
        {
            get { return _PlateModel; }
            set { _PlateModel = value; }
        }

        private int _Thickness;
        [DisplayName("板厚")]
        public int Thickness
        {
            get { return _Thickness; }
            set { _Thickness = value; }
        }

        private int _Width1;
        [DisplayName("宽度1")]
        public int Width1
        {
            get { return _Width1; }
            set { _Width1 = value; }
        }

        private int _Length1;
        [DisplayName("长度1")]
        public int Length1
        {
            get { return _Length1; }
            set { _Length1 = value; }
        }

        private double _TransverseCurvate;
        [DisplayName("纵向曲率")]
        public double TransverseCurvate
        {
            get { return _TransverseCurvate; }
            set { _TransverseCurvate = value; }
        }

        private int _RiblineCount;
        [DisplayName("肋位线数目")]
        public int RiblineCount
        {
            get { return _RiblineCount; }
            set { _RiblineCount = value; }
        }

        private int _SideCount;
        [DisplayName("边数")]
        public int SideCount
        {
            get { return _SideCount; }
            set { _SideCount = value; }
        }

        private double _LongitudinalCurvature;
        [DisplayName("纵向曲率")]
        public double LongitudinalCurvature
        {
            get { return _LongitudinalCurvature; }
            set { _LongitudinalCurvature = value; }
        }

        private string _CurvePlateKind;
        [DisplayName("曲板类型")]
        public string CurvePlateKind
        {
            get { return _CurvePlateKind; }
            set { _CurvePlateKind = value; }
        }

        private double _Width2;
        [DisplayName("宽度2")]
        public double Width2
        {
            get { return _Width2; }
            set { _Width2 = value; }
        }

        private double _Length2;
        [DisplayName("长度2")]
        public double Length2
        {
            get { return _Length2; }
            set { _Length2 = value; }
        }

        private string _ShipName;
        [DisplayName("船名")]
        public string ShipName
        {
            get { return _ShipName; }
            set { _ShipName = value; }
        }

        private string _MaterialName;
        [DisplayName("材料名称")]
        public string MaterialName
        {
            get { return _MaterialName; }
            set { _MaterialName = value; }
        }

    }
}
