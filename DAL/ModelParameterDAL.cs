using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;
using HullShellTest.ModelData.Extent;

namespace HullShellTest.DAL
{
    public class ModelParameterDAL
    {
        //增加
        //public int AddModelParameter(ModelParameterCls mpc)
        //{
        //    using (HullShellContainer hs = new HullShellContainer())
        //    {

        //        //测量点云
        //        ScanPoints spts = new ScanPoints
        //        {
        //            FileName=mpc.spc.FileName
        //        };

        //        for (int i = 0; i < mpc.spc.SPList.Count;i++ )
        //        {
        //            Point pt = new Point
        //            {
        //                X=mpc.spc.SPList[i].x,
        //                Y = mpc.spc.SPList[i].y,
        //                Z = mpc.spc.SPList[i].z
        //            };

        //            spts.Point.Add(pt);

        //        }

        //        //调形文件
        //        AdjustShapeFile asf = new AdjustShapeFile
        //        {
        //            FileName=mpc.asfc.FileName
        //        };

        //        for (int i = 0; i < mpc.asfc.HeightValuesList.Count;i++ )
        //        {
        //            HeightValueList hvs = new HeightValueList
        //            {
        //                R=mpc.asfc.HeightValuesList[i].C,
        //                C=mpc.asfc.HeightValuesList[i].R,
        //                Z=mpc.asfc.HeightValuesList[i].Z
        //            };

        //            asf.HeightValueList.Add(hvs);
        //        }

        //        //插值文件
        //        InterpolationFile _if = new InterpolationFile
        //        {
        //            FileName = mpc.ifc.FileName
        //        };

        //        for (int i = 0; i < mpc.ifc.InterpolationList.Count; i++)
        //        {
        //            HeightValueList hvs = new HeightValueList
        //            {
        //                R = mpc.ifc.InterpolationList[i].C,
        //                C = mpc.ifc.InterpolationList[i].R,
        //                Z = mpc.ifc.InterpolationList[i].Z
        //            };

        //            _if.HeightValueList.Add(hvs);
        //        }

        //        //缺陷
        //        DefectsList dlc = new DefectsList
        //        {
        //            DefectName = mpc.dlc.DefectName,
        //            DefectReason=mpc.dlc.DefectReason,
        //            Solution=mpc.dlc.Slution
        //        };


        //        ModelingParameter mp = new ModelingParameter
        //        {
        //            //基本属性
        //            ProcessNumbers=mpc.ProcessNumbers,
        //            EnvTemperation=mpc.EnvTemperation,
        //            RecordTime=mpc.RecordTime,
        //            Coefficient=mpc.Coefficient,
        //            ResilienceValue=mpc._ResilienceValue,
        //            //索引属性
        //            StdHullShell = hs.StdHullShellSet.Where(s => s.PlateModel == mpc.StdHullName).FirstOrDefault(),
        //            ProcessingEquipment = hs.ProcessingEquipmentSet.Where(s => s.EquipMentName == mpc.ProcessEquipmentName).FirstOrDefault(),
        //            Software = hs.SoftwareSet.Where(s => s.SoftwareName == mpc.SoftwareName).FirstOrDefault(),
        //            DetectEquipment = hs.DetectEquipmentSet.Where(s => s.DetectEquipmentName == mpc.DetectEquipmentName).FirstOrDefault(),
        //            Admins=hs.AdminsSet.Where(a=>a.UserName==mpc.UserName).FirstOrDefault(),

        //            //关联属性
        //            ScanPoints = spts,
        //            AdjustShapeFile=asf,
        //            InterpolationFile=_if,
        //            DefectsList=dlc,


        //        };

        //        hs.AddToModelingParameterSet(mp);

        //        return hs.SaveChanges();
        //    }
        //}

        //增加
        public static int AddModelParameter(ModelParamterBasicCls mpc)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ModelingParameter mp = new ModelingParameter
                {
                    //基本属性
                    ProcessNumbers = mpc.ProcessNumbers,
                    EnvTemperation = mpc.EnvTemperation,
                    RecordTime = mpc.RecordTime,
                    Coefficient = mpc.Coefficient,
                    ResilienceValue = mpc._ResilienceValue,
                    //索引属性
                    StdHullShell = hs.StdHullShellSet.Where(s => s.PlateModel == mpc.StdHullName).FirstOrDefault(),
                    ProcessingEquipment = hs.ProcessingEquipmentSet.Where(s => s.EquipMentName == mpc.ProcessEquipmentName).FirstOrDefault(),
                    Software = hs.SoftwareSet.Where(s => s.SoftwareName == mpc.SoftwareName).FirstOrDefault(),
                    DetectEquipment = hs.DetectEquipmentSet.Where(s => s.DetectEquipmentName == mpc.DetectEquipmentName).FirstOrDefault(),
                    Admins = hs.AdminsSet.Where(a => a.UserName == mpc.UserName).FirstOrDefault(),

                    //关联属性
                    //ScanPoints = spts,
                    //AdjustShapeFile = asf,
                    //InterpolationFile = _if,
                    //DefectsList = dlc,
                };

                hs.AddToModelingParameterSet(mp);

                return hs.SaveChanges();
            }
        }
        ////删除
        //public int DeleteModelParameter(string _name,int time)
        //{
        //    using (HullShellContainer hs = new HullShellContainer())
        //    {
        //        ModelingParameter mp = hs.ModelingParameterSet.Where(a => a.StdHullShell.PlateModel == _name && a.ProcessNumbers == time).FirstOrDefault();

        //        if (mp == null)
        //        {
        //            return 0;
        //        }

        //        //删除缺陷
        //        hs.DeleteObject(mp);
        //        hs.DeleteObject(mp.DefectsList);

        //        //删除调形文件
        //        hs.DeleteObject(mp.AdjustShapeFile);
        //        List<HeightValueList> hvl = mp.AdjustShapeFile.HeightValueList.ToList();
        //        for (int i = 0; i < hvl.Count;i++ )
        //        {
        //            hs.DeleteObject(hvl[i]);
        //        }

        //        //删除插值文件
        //        hs.DeleteObject(mp.InterpolationFile);
        //        List<HeightValueList> hvl1 = mp.InterpolationFile.HeightValueList.ToList();
        //        for (int i = 0; i < hvl1.Count; i++)
        //        {
        //            hs.DeleteObject(hvl1[i]);
        //        }

        //        //删除点云文件
        //        hs.DeleteObject(mp.ScanPoints);
        //        List<Point> spList = mp.ScanPoints.Point.ToList();
        //        for (int i = 0; i < spList.Count;i++ )
        //        {
        //            hs.DeleteObject(spList[i]);
        //        }

        //        hs.DeleteObject(mp);

        //        return hs.SaveChanges();

        //    }
        //}
        ////////////////////////////////////////////////////////////////////////////
        ////修改
        //public int ModifyModelParameter(ModelParameterCls mpc)
        //{
        //    using (HullShellContainer hs = new HullShellContainer())
        //    {
        //        ModelingParameter mp = hs.ModelingParameterSet.Where(m => m.StdHullShell.PlateModel == mpc.StdHullName && m.ProcessNumbers == mpc.ProcessNumbers).FirstOrDefault();

        //        mp.EnvTemperation=mpc.EnvTemperation;
        //        mp.RecordTime=mpc.RecordTime;
        //        mp.Coefficient = mpc.Coefficient;
        //        mp.ResilienceValue=mpc.ResilienceValue;

        //        return hs.SaveChanges();
        //    }
        //}

        ////查询
        //public ModelParameterCls QueryModelParameter(string _name,int time)
        //{
        //    using (HullShellContainer hs = new HullShellContainer())
        //    {
        //        ModelingParameter mp = hs.ModelingParameterSet.Where(a => a.StdHullShell.PlateModel == _name && a.ProcessNumbers == time).FirstOrDefault();

        //        ModelParameterCls mpc = new ModelParameterCls();
        //        mpc.EnvTemperation = mp.EnvTemperation;
        //        mpc.RecordTime = mp.RecordTime;
        //        mpc.Coefficient = mp.Coefficient;
        //        mpc.ResilienceValue = mp.ResilienceValue;

        //        mpc.ProcessEquipmentName = mp.ProcessingEquipment.EquipMentName;
        //        mpc.DetectEquipmentName = mp.DetectEquipment.DetectEquipmentName;
        //        mpc.SoftwareName = mp.Software.SoftwareName;
        //        mpc.UserName = mp.Admins.UserName;

        //        mpc.spc.FileName = mp.ScanPoints.FileName;
        //        mpc.asfc.FileName = mp.AdjustShapeFile.FileName;
        //        mpc.ifc.FileName = mp.InterpolationFile.FileName;
        //        mpc.dlc.Id = mp.DefectsList.Id;

        //        return mpc;
        //    }
        //}

        ////清空
        //public int ClearModelParameter()
        //{
        //    using (HullShellContainer hs = new HullShellContainer())
        //    {
        //        List<ModelingParameter> mpList = hs.ModelingParameterSet.Where(a => a.Id >= 0).ToList();

        //        for (int i = 0; i < mpList.Count; i++)
        //        {
        //            hs.DeleteObject(mpList[i]);
        //        }

        //        return hs.SaveChanges();
        //    }

        //}


        //查询加工数据
        public static List<string> QueryModelParameter(string StdHullName)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                //hs.ModelingParameterSet.

                int _Id = hs.StdHullShellSet.Where(s => s.PlateModel == StdHullName).FirstOrDefault().Id;

                StdHullShell shs = hs.StdHullShellSet.Where(s => s.PlateModel == StdHullName).FirstOrDefault();

                List<ModelingParameter> mpL=shs.ModelingParameter.ToList();

                int x=shs.ModelingParameter.ToList().Count();

                //shs.ModelingParameter.Load();


                ModelingParameter mp = hs.ModelingParameterSet.Where(m=>m.Id>0).FirstOrDefault();

                List<ModelingParameter> mpList = hs.ModelingParameterSet.Where(m => m.StdHullShell.Id == _Id).ToList();

                List<string> namestr = new List<string>();

                //List<ModelingParameter> mpList = hs.StdHullShellSet.Where(a => a.Id == _Id).FirstOrDefault().ModelingParameter.ToList();

                for (int i = 0; i < mpList.Count; i++)
                {
                    namestr.Add("加工:"+mpList[i].Id);
                }

                //ExcessPoints eeps = shs.ExcessPoints;
                //List<Point> eepList = eeps.Point.ToList();

                return namestr;
            }
        }

        //查询加工数据
        public static void QueryModelParameter()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ModelingParameter mp = hs.ModelingParameterSet.Where(m => m.Id > 0).FirstOrDefault();
            }
        }


    }
}
