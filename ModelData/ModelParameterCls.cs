using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData.Extent;

namespace HullShellTest.ModelData
{
    public class ModelParameterCls
    {
        public ModelParameterCls()
        {
        }

        //构造函数
        public ModelParameterCls(int count)
        {
            spc = new ScanPointsCls();

            asfc = new AdjustShapeFileCls();
            ifc = new InterpolationFileCls();
            dlc = new DefectsListCls();

            BasicInfo = new ModelParamterBasicCls();
        }

        //基本信息
        public ModelParamterBasicCls BasicInfo;
        //测量软件
        public ScanPointsCls spc;

        //调形文件及对应名字
        public AdjustShapeFileCls asfc;

        //插值文件及对应名字
        public InterpolationFileCls ifc;

        //缺陷
        public DefectsListCls dlc;
    }
}
