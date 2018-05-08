using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.DAL
{
    public class AdjustShapeFileDAL
    {
        //增加调形文件
        public int AddShapeFile(AdjustShapeFileCls AsFileCls)
        {
            using(HullShellContainer hs=new HullShellContainer())
            {
                AdjustShapeFile asf = new AdjustShapeFile
                {
                    FileName=AsFileCls.FileName
                };

                for (int i = 0; i < AsFileCls.HeightValuesList.Count;i++ )
                {
                    HeightValueList hv = new HeightValueList
                    {
                        R = AsFileCls.HeightValuesList[i].R,
                        C = AsFileCls.HeightValuesList[i].C,
                        Z = AsFileCls.HeightValuesList[i].Z,
                    };

                    asf.HeightValueList.Add(hv);
                }

                hs.AddToAdjustShapeFileSet(asf);
                return hs.SaveChanges();
            }
        }


        

    }
}
