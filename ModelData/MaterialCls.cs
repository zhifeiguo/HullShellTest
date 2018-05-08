using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HullShellTest.ModelData
{
    public class MaterialCls
    {
        //序号
        private int _Id;
        [DisplayName("序号")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        //材料名称
        private string _MaterialName;
        [DisplayName("材料名称")]
        public string MaterialName
        {
            get { return _MaterialName; }
            set { _MaterialName = value; }
        }

        //弹性模量
        private double? _ElasticModulus;
        [DisplayName("弹性模量")]
        public double? ElasticModulus
        {
            get { return _ElasticModulus; }
            set { _ElasticModulus = value; }
        }

        //屈服模量
        private double? _YieldSrength;
        [DisplayName("屈服强度")]
        public double? YieldSrength
        {
            get { return _YieldSrength; }
            set { _YieldSrength = value; }
        }

        //抗拉强度
        private double? _TensileStrength;
        [DisplayName("抗拉强度")]
        public double? TensileStrength
        {
            get { return _TensileStrength; }
            set { _TensileStrength = value; }
        }

        //极限伸长量UltimateElongation
        private double? _UltimateElongation;
        [DisplayName("极限伸长量")]
        public double? UltimateElongation
        {
            get { return _UltimateElongation; }
            set { _UltimateElongation = value; }
        }

        //断面收缩率
        private double? _ReductionOfArea;
        [DisplayName("断面收缩率")]
        public double? ReductionOfArea
        {
            get { return _ReductionOfArea; }
            set { _ReductionOfArea = value; }
        }

        //硬化指数
        private double? _HardenablityValue;
        [DisplayName("硬化指数")]
        public double? HardenablityValue
        {
            get { return _HardenablityValue; }
            set { _HardenablityValue = value; }
        }

        //StrainOfWidthAndThickness
        private double? _StrainOfWidthAndThickness;
        [DisplayName("厚向异性系数")]
        public double? StrainOfWidthAndThickness
        {
            get { return _StrainOfWidthAndThickness; }
            set { _StrainOfWidthAndThickness = value; }
        }

    }
}
