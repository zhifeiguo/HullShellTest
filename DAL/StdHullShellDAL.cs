using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;
using HullShellTest.ModelData.Extent;

namespace HullShellTest.DAL
{
    public class StdHullShellDAL
    {
        //增加
        public static int AddStdHullShell(StdHullShellCls StdShell)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                //包围盒
                BoundingBox boundbox = new BoundingBox { x_Dir = StdShell.Dir.x,
                y_Dir = StdShell.Dir.y,
                z_Dir = StdShell.Dir.z,

                x_Min = StdShell.Pt_Min.x,
                y_Min = StdShell.Pt_Min.y,
                z_Min = StdShell.Pt_Min.z,

                x_Max = StdShell.Pt_Max.x,
                y_Max = StdShell.Pt_Max.y,
                z_Max = StdShell.Pt_Max.z };

                //增加回弹属性
                ResilienceFactor rf = new ResilienceFactor() { ResilienCoefficient = StdShell.rfc.ResilienCoefficient,
                CurvatureRange = StdShell.rfc.CurvatureRange,
                WidthRange = StdShell.rfc.WidthRange,
                Curvature = StdShell.rfc.Curvature };

                //理论点
                TheoryPoints tps = new TheoryPoints { RowNumber = StdShell.tpc.RowNumberow,
                ColumnNumber = StdShell.tpc.ColnumNumber };

                for (int i = 0; i < StdShell.tpc.PointsCloudList.Count; i++)
                {
                    Point pt = new Point { X = StdShell.tpc.PointsCloudList[i].x,
                    Y = StdShell.tpc.PointsCloudList[i].y,
                    Z = StdShell.tpc.PointsCloudList[i].z };

                    tps.Point.Add(pt);
                }

                //增加肋位线点
                RiblinePoints rps = new RiblinePoints();

                for (int i = 0; i < StdShell.tpc.RiblinePointsList.Count; i++)
                {
                    Point pt = new Point { X = StdShell.tpc.RiblinePointsList[i].x,
                    Y = StdShell.tpc.RiblinePointsList[i].y,
                    Z = StdShell.tpc.RiblinePointsList[i].z };

                    rps.Point.Add(pt);
                }

                //增加边缘交点
                EdgeEdgePoints eeps = new EdgeEdgePoints();
                for (int i = 0; i < StdShell.tpc.EdgeEdgePointsList.Count; i++)
                {
                    Point pt = new Point { X = StdShell.tpc.EdgeEdgePointsList[i].x,
                    Y = StdShell.tpc.EdgeEdgePointsList[i].y,
                    Z = StdShell.tpc.EdgeEdgePointsList[i].z };

                    eeps.Point.Add(pt);
                }

                //增加余量点
                ExcessPoints expts = new ExcessPoints();
                for (int i = 0; i < StdShell.tpc.ExcessPointsList.Count; i++)
                {
                    Point pt = new Point { X = StdShell.tpc.ExcessPointsList[i].x,
                    Y = StdShell.tpc.ExcessPointsList[i].y,
                    Z = StdShell.tpc.ExcessPointsList[i].z };

                    expts.Point.Add(pt);
                }

                //查询材料
                Material mal = hs.MaterialSet.Where(m => m.MaterialName == StdShell.StdHullBasicInfo.MaterialName).FirstOrDefault();

                //添加
                StdHullShell shs = new StdHullShell {
                PlateModel = StdShell.StdHullBasicInfo.PlateModel,
                Thickness = StdShell.StdHullBasicInfo.Thickness,
                Width1 = StdShell.StdHullBasicInfo.Width1,
                Length1 = StdShell.StdHullBasicInfo.Length1,
                TransverseCurvate = StdShell.StdHullBasicInfo.TransverseCurvate,
                RiblineAmount = StdShell.StdHullBasicInfo.RiblineCount,
                SideAmount = StdShell.StdHullBasicInfo.SideCount,
                LongitudinalCurvature = StdShell.StdHullBasicInfo.LongitudinalCurvature,
                CurvePlateKind = StdShell.StdHullBasicInfo.CurvePlateKind,
                Width2 = StdShell.StdHullBasicInfo.Width2,
                Length2 = StdShell.StdHullBasicInfo.Length2,
                ShipName = StdShell.StdHullBasicInfo.ShipName,

                Material=mal,

                TheoryPoints = tps,
                RiblinePoints = rps,
                EdgeEdgePoints = eeps,
                ExcessPoints = expts,

                BoundingBox = boundbox,

                ResilienceFactor = rf 

                };


                hs.AddToStdHullShellSet(shs);

                return hs.SaveChanges();
            }
        }

        //删除 ByName
        public static int DeleteStdHullShellByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                StdHullShell shs = hs.StdHullShellSet.Where(s => s.PlateModel == _name).FirstOrDefault();

                //删除包围盒
                BoundingBox boundbox = shs.BoundingBox;
                hs.DeleteObject(boundbox);

                //删除理论点
                TheoryPoints tps = shs.TheoryPoints;
                List<Point> tpsList = tps.Point.ToList();
                for (int i = 0; i < tpsList.Count; i++)
                {
                    hs.DeleteObject(tpsList[i]);
                }
                hs.DeleteObject(tps);

                //删除肋位线点
                RiblinePoints rps = shs.RiblinePoints;
                List<Point> rpList = rps.Point.ToList();
                for (int i = 0; i < rpList.Count; i++)
                {
                    hs.DeleteObject(rpList[i]);
                }
                hs.DeleteObject(rps);

                //删除余量点
                ExcessPoints eeps = shs.ExcessPoints;
                List<Point> eepList = eeps.Point.ToList();
                for (int i = 0; i < eepList.Count; i++)
                {
                    hs.DeleteObject(eepList[i]);
                }
                hs.DeleteObject(eeps);

                //删除边角点
                EdgeEdgePoints exps = shs.EdgeEdgePoints;
                List<Point> expList = exps.Point.ToList();
                for (int i = 0; i < expList.Count; i++)
                {
                    hs.DeleteObject(expList[i]);
                }
                hs.DeleteObject(exps);

                hs.DeleteObject(shs);

                return hs.SaveChanges();
            }
        }

        //删除，ById
        public static int DeleteStdHullShellById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                StdHullShell shs = hs.StdHullShellSet.Where(s => s.Id == Id).FirstOrDefault();

                //删除包围盒
                shs.BoundingBoxReference.Load();
                BoundingBox boundbox = shs.BoundingBox;
                hs.DeleteObject(boundbox);

                //删除理论点
                shs.TheoryPointsReference.Load();
                shs.TheoryPoints.Point.Load();
                TheoryPoints tps = shs.TheoryPoints;
                List<Point> tpsList = tps.Point.ToList();
                for (int i = 0; i < tpsList.Count; i++)
                {
                    hs.DeleteObject(tpsList[i]);
                }
                hs.DeleteObject(tps);

                //删除肋位线点
                shs.RiblinePointsReference.Load();
                shs.RiblinePoints.Point.Load();
                RiblinePoints rps = shs.RiblinePoints;
                List<Point> rpList = rps.Point.ToList();
                for (int i = 0; i < rpList.Count; i++)
                {
                    hs.DeleteObject(rpList[i]);
                }
                hs.DeleteObject(rps);

                //删除余量点
                shs.ExcessPointsReference.Load();
                shs.ExcessPoints.Point.Load();
                ExcessPoints eeps = shs.ExcessPoints;

                List<Point> eepList = eeps.Point.ToList();
                for (int i = 0; i < eepList.Count; i++)
                {
                    hs.DeleteObject(eepList[i]);
                }
                hs.DeleteObject(eeps);

                //删除边角点
                shs.EdgeEdgePointsReference.Load();
                shs.EdgeEdgePoints.Point.Load();
                EdgeEdgePoints exps = shs.EdgeEdgePoints;
                List<Point> expList = exps.Point.ToList();
                for (int i = 0; i < expList.Count; i++)
                {
                    hs.DeleteObject(expList[i]);
                }
                hs.DeleteObject(exps);

                shs.ResilienceFactorReference.Load();
                ResilienceFactor rfc = shs.ResilienceFactor;
                hs.DeleteObject(rfc);

                hs.DeleteObject(shs);

                return hs.SaveChanges();
            }
        }

        //修改,基本信息，ByName
        public static int ModifyStdHullShellByName(StdHullShellCls StdShell)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                StdHullShell shs = hs.StdHullShellSet.Where(s => s.PlateModel == StdShell.StdHullBasicInfo.PlateModel).FirstOrDefault();

                shs.PlateModel = StdShell.StdHullBasicInfo.PlateModel;
                shs.Thickness = StdShell.StdHullBasicInfo.Thickness;
                shs.Width1 = StdShell.StdHullBasicInfo.Width1;
                shs.Length1 = StdShell.StdHullBasicInfo.Length1;
                shs.TransverseCurvate = StdShell.StdHullBasicInfo.TransverseCurvate;
                shs.RiblineAmount = StdShell.StdHullBasicInfo.RiblineCount;
                shs.LongitudinalCurvature = StdShell.StdHullBasicInfo.LongitudinalCurvature;
                shs.CurvePlateKind = StdShell.StdHullBasicInfo.CurvePlateKind;
                shs.Width2 = StdShell.StdHullBasicInfo.Width2;
                shs.Length2 = StdShell.StdHullBasicInfo.Length2;
                shs.ShipName = StdShell.StdHullBasicInfo.ShipName;

                shs.BoundingBox.x_Dir = StdShell.Dir.x;
                shs.BoundingBox.y_Dir = StdShell.Dir.y;
                shs.BoundingBox.z_Dir = StdShell.Dir.z;

                shs.BoundingBox.x_Min = StdShell.Pt_Min.x;
                shs.BoundingBox.y_Min = StdShell.Pt_Min.y;
                shs.BoundingBox.z_Min = StdShell.Pt_Min.z;

                shs.BoundingBox.x_Max = StdShell.Pt_Max.x;
                shs.BoundingBox.y_Max = StdShell.Pt_Max.y;
                shs.BoundingBox.z_Max = StdShell.Pt_Max.z;

                return hs.SaveChanges();
            }
        }

        //修改,基本信息，ById
        public static int ModifyStdHullShellById(StdHullShellCls StdShell)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                int re=-1;
                StdHullShell shs = hs.StdHullShellSet.Where(s => s.Id == StdShell.StdHullBasicInfo.Id).FirstOrDefault();

                shs.PlateModel = StdShell.StdHullBasicInfo.PlateModel;
                shs.Thickness = StdShell.StdHullBasicInfo.Thickness;
                shs.Width1 = StdShell.StdHullBasicInfo.Width1;
                shs.Length1 = StdShell.StdHullBasicInfo.Length1;
                shs.TransverseCurvate = StdShell.StdHullBasicInfo.TransverseCurvate;
                shs.RiblineAmount = StdShell.StdHullBasicInfo.RiblineCount;
                shs.SideAmount = StdShell.StdHullBasicInfo.SideCount;
                shs.LongitudinalCurvature = StdShell.StdHullBasicInfo.LongitudinalCurvature;
                shs.CurvePlateKind = StdShell.StdHullBasicInfo.CurvePlateKind;
                shs.Width2 = StdShell.StdHullBasicInfo.Width2;
                shs.Length2 = StdShell.StdHullBasicInfo.Length2;
                shs.ShipName = StdShell.StdHullBasicInfo.ShipName;

                shs.ResilienceFactorReference.Load();
                shs.ResilienceFactor.ResilienCoefficient = StdShell.rfc.ResilienCoefficient;
                shs.ResilienceFactor.CurvatureRange = StdShell.rfc.CurvatureRange;
                shs.ResilienceFactor.Curvature = StdShell.rfc.Curvature;
                shs.ResilienceFactor.WidthRange = StdShell.rfc.WidthRange;


                //shs.BoundingBox.x_Dir = StdShell.Dir.x;
                //shs.BoundingBox.y_Dir = StdShell.Dir.y;
                //shs.BoundingBox.z_Dir = StdShell.Dir.z;

                //shs.BoundingBox.x_Min = StdShell.Pt_Min.x;
                //shs.BoundingBox.y_Min = StdShell.Pt_Min.y;
                //shs.BoundingBox.z_Min = StdShell.Pt_Min.z;

                //shs.BoundingBox.x_Max = StdShell.Pt_Max.x;
                //shs.BoundingBox.y_Max = StdShell.Pt_Max.y;
                //shs.BoundingBox.z_Max = StdShell.Pt_Max.z;

                return re=hs.SaveChanges();
            }
        }

        //查询
        public StdHullShellCls QueryStdHullShellByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                StdHullShellCls shscls = new StdHullShellCls();
                StdHullShell shs = hs.StdHullShellSet.Where(s => s.PlateModel == _name).FirstOrDefault();

                shscls.StdHullBasicInfo.PlateModel = shs.PlateModel;
                shscls.StdHullBasicInfo.Thickness = shs.Thickness;
                shscls.StdHullBasicInfo.Width1 = shs.Width1;
                shscls.StdHullBasicInfo.Length1 = shs.Length1;

                shscls.StdHullBasicInfo.PlateModel = shs.PlateModel;
                shscls.StdHullBasicInfo.Thickness = shs.Thickness;
                shscls.StdHullBasicInfo.Width1 = shs.Width1;
                shscls.StdHullBasicInfo.Length1 = shs.Length1;
                shscls.StdHullBasicInfo.TransverseCurvate = shs.TransverseCurvate;
                shscls.StdHullBasicInfo.RiblineCount = shs.RiblineAmount;
                shscls.StdHullBasicInfo.LongitudinalCurvature = shs.LongitudinalCurvature;
                shscls.StdHullBasicInfo.CurvePlateKind = shs.CurvePlateKind;
                shscls.StdHullBasicInfo.Width2 = shs.Width2;
                shscls.StdHullBasicInfo.Length2 = shs.Length2;
                shscls.StdHullBasicInfo.ShipName = shs.ShipName;

                List<Point> tpsList = shs.TheoryPoints.Point.ToList();
                for (int i = 0; i < tpsList.Count; i++ )
                {
                    shscls.tpc.PointsCloudList.Add(new PointCls { x = tpsList[i].X, y = tpsList[i].Y, z = tpsList[i].Z });
                }

                List<Point> rpsList = shs.RiblinePoints.Point.ToList();
                for (int i = 0; i < rpsList.Count; i++)
                {
                    shscls.tpc.RiblinePointsList.Add(new PointCls { x = tpsList[i].X, y = tpsList[i].Y, z = tpsList[i].Z });
                }

                List<Point> eepList = shs.EdgeEdgePoints.Point.ToList();
                for (int i = 0; i < eepList.Count; i++)
                {
                    shscls.tpc.EdgeEdgePointsList.Add(new PointCls { x = tpsList[i].X, y = tpsList[i].Y, z = tpsList[i].Z });
                }

                List<Point> expList = shs.ExcessPoints.Point.ToList();
                for (int i = 0; i < expList.Count; i++)
                {
                    shscls.tpc.ExcessPointsList.Add(new PointCls { x = tpsList[i].X, y = tpsList[i].Y, z = tpsList[i].Z });
                }

                shscls.Dir.x = shs.BoundingBox.x_Dir;
                shscls.Dir.y = shs.BoundingBox.y_Dir;
                shscls.Dir.z = shs.BoundingBox.z_Dir;

                shscls.Pt_Min.x = shs.BoundingBox.x_Min;
                shscls.Pt_Min.y = shs.BoundingBox.y_Min;
                shscls.Pt_Min.z = shs.BoundingBox.z_Min;

                shscls.Pt_Max.x = shs.BoundingBox.y_Max;
                shscls.Pt_Max.y = shs.BoundingBox.y_Max;
                shscls.Pt_Max.z = shs.BoundingBox.z_Max;

                return shscls;
            }
        }

        //清空
        public int ClearProcessEquipment()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                int re = 0;

                List<StdHullShell> shsList = hs.StdHullShellSet.Where(p => p.Id >= 0).ToList();
                //StdHullShell shs = hs.StdHullShellSet.Where(s => s.PlateModel == _name).FirstOrDefault();

                for (int i = 0; i < shsList.Count; i++)
                {
                    re = DeleteStdHullShellById(shsList[i].Id);
                }

                return re;
            }
        }

        //查询所有船板基本信息
        public static List<StdHullBasicInformationCls> GetAllStdHullShell()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<StdHullBasicInformationCls> ShsCls = new List<StdHullBasicInformationCls>();

                int re = 0;

                List<StdHullShell> shsList = hs.StdHullShellSet.Where(p => p.Id >= 0).ToList();

                for (int i = 0; i < shsList.Count; i++)
                {
                    shsList[i].MaterialReference.Load();
 
                    StdHullBasicInformationCls StdHullBasic = new StdHullBasicInformationCls {
                    Id =shsList[i].Id,
                    PlateModel = shsList[i].PlateModel,
                    Thickness = shsList[i].Thickness,
                    Width1 = shsList[i].Width1,
                    Length1 = shsList[i].Length1,
                    Width2 = shsList[i].Width2,
                    Length2 = shsList[i].Length2,
                    SideCount = shsList[i].SideAmount,
                    RiblineCount = shsList[i].RiblineAmount,
                    TransverseCurvate = shsList[i].TransverseCurvate,
                    LongitudinalCurvature = shsList[i].LongitudinalCurvature,
                    CurvePlateKind = shsList[i].CurvePlateKind,
                    ShipName = shsList[i].ShipName,
                    MaterialName = shsList[i].Material.MaterialName.ToString()
                    };

                    ShsCls.Add(StdHullBasic);
                }

                return ShsCls;
            }
        }

        //根据Name查询船板基本信息
        public static StdHullBasicInformationCls GetStdHullBasicInfoByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                //StdHullBasicInformationCls ShsCls = new StdHullBasicInformationCls();

                int re = 0;

                StdHullShell shs = hs.StdHullShellSet.Where(p => p.PlateModel == _name).FirstOrDefault();

                shs.MaterialReference.Load();

                StdHullBasicInformationCls StdHullBasic = new StdHullBasicInformationCls
                {
                    Id = shs.Id,
                    PlateModel = shs.PlateModel,
                    Thickness = shs.Thickness,
                    Width1 = shs.Width1,
                    Length1 = shs.Length1,
                    Width2 = shs.Width2,
                    Length2 = shs.Length2,
                    SideCount = shs.SideAmount,
                    RiblineCount = shs.RiblineAmount,
                    TransverseCurvate = shs.TransverseCurvate,
                    LongitudinalCurvature = shs.LongitudinalCurvature,
                    CurvePlateKind = shs.CurvePlateKind,
                    ShipName = shs.ShipName,
                    MaterialName = shs.Material.MaterialName.ToString()
                };

                return StdHullBasic;
            }
        }

        //获取回弹值信息
        public static ResilienceFactorCls GeteResilienceFactorById(int _Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                int re = 0;

                StdHullShell shs = hs.StdHullShellSet.Where(p => p.Id == _Id).FirstOrDefault();

                shs.ResilienceFactorReference.Load();

                ResilienceFactorCls rf = new ResilienceFactorCls()
                {
                    Id=shs.ResilienceFactor.Id,
                    ResilienCoefficient = shs.ResilienceFactor.ResilienCoefficient,
                    CurvatureRange = shs.ResilienceFactor.CurvatureRange,
                    WidthRange = shs.ResilienceFactor.WidthRange,
                    Curvature = shs.ResilienceFactor.CurvatureRange
                };

                return rf;
            }
        }


       }
}
