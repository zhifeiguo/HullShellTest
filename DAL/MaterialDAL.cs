using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.DAL
{
    public class MaterialDAL
    {
        //增加
        public static int AddMaterial(MaterialCls _mac)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Material mal = new Material
                {
                    MaterialName=_mac.MaterialName,
                    ElasticModulus=_mac.ElasticModulus,
                    YieldSrength=_mac.YieldSrength,
                    TensileStrength=_mac.TensileStrength,
                    UltimateElongation=_mac.UltimateElongation,
                    ReductionOfArea=_mac.ReductionOfArea,
                    HardenablityValue=_mac.HardenablityValue,
                    StrainOfWidthAndThickness=_mac.StrainOfWidthAndThickness
                };

                hs.AddToMaterialSet(mal);
                return hs.SaveChanges();
            }
        }

        //删除
        public static int DeleteMaterialByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Material mal = hs.MaterialSet.Where(m => m.MaterialName == _name).FirstOrDefault();

                hs.DeleteObject(mal);

                return hs.SaveChanges();

            }
        }

        public static int DeleteMaterialById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Material mal = hs.MaterialSet.Where(m => m.Id == Id).FirstOrDefault();

                hs.DeleteObject(mal);

                return hs.SaveChanges();

            }
        }

        //修改
        public static int ModifyMaterialByName(MaterialCls _mac)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Material mal = hs.MaterialSet.Where(m => m.MaterialName == _mac.MaterialName).FirstOrDefault();

                mal.MaterialName = _mac.MaterialName;
                mal.ElasticModulus = _mac.ElasticModulus;
                mal.YieldSrength = _mac.YieldSrength;
                mal.TensileStrength = _mac.TensileStrength;
                mal.UltimateElongation = _mac.UltimateElongation;
                mal.ReductionOfArea = _mac.ReductionOfArea;
                mal.HardenablityValue = _mac.HardenablityValue;
                mal.StrainOfWidthAndThickness = _mac.StrainOfWidthAndThickness;

                return hs.SaveChanges();
            }
        }

        public static int ModifyMaterialByid(MaterialCls _mac)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Material mal = hs.MaterialSet.Where(m => m.Id== _mac.Id).FirstOrDefault();

                mal.MaterialName = _mac.MaterialName;
                mal.ElasticModulus = _mac.ElasticModulus;
                mal.YieldSrength = _mac.YieldSrength;
                mal.TensileStrength = _mac.TensileStrength;
                mal.UltimateElongation = _mac.UltimateElongation;
                mal.ReductionOfArea = _mac.ReductionOfArea;
                mal.HardenablityValue = _mac.HardenablityValue;
                mal.StrainOfWidthAndThickness = _mac.StrainOfWidthAndThickness;

                return hs.SaveChanges();
            }
        }

        //查询
        public static MaterialCls QueryMaterialByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Material mal = hs.MaterialSet.Where(m => m.MaterialName == _name).FirstOrDefault();

                MaterialCls _mac = new MaterialCls();

                _mac.Id = mal.Id;
                _mac.MaterialName = mal.MaterialName;
                _mac.ElasticModulus = mal.ElasticModulus;
                _mac.YieldSrength = mal.YieldSrength;
                _mac.TensileStrength = mal.TensileStrength;
                _mac.UltimateElongation = mal.UltimateElongation;
                _mac.ReductionOfArea = mal.ReductionOfArea;
                _mac.HardenablityValue = mal.HardenablityValue;
                _mac.StrainOfWidthAndThickness = mal.StrainOfWidthAndThickness;


                return _mac;
            }
        }

        public static MaterialCls QueryMaterialById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Material mal = hs.MaterialSet.Where(m => m.Id == Id).FirstOrDefault();

                MaterialCls _mac = new MaterialCls();

                _mac.Id = mal.Id;
                _mac.MaterialName = mal.MaterialName;
                _mac.ElasticModulus = mal.ElasticModulus;
                _mac.YieldSrength = mal.YieldSrength;
                _mac.TensileStrength = mal.TensileStrength;
                _mac.UltimateElongation = mal.UltimateElongation;
                _mac.ReductionOfArea = mal.ReductionOfArea;
                _mac.HardenablityValue = mal.HardenablityValue;
                _mac.StrainOfWidthAndThickness = mal.StrainOfWidthAndThickness;


                return _mac;
            }
        }

        //清空
        public static int ClearMaterial()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<Material> MaterialList = hs.MaterialSet.Where(m => m.Id >= 0).ToList();

                for (int i = 0; i < MaterialList.Count; i++)
                {
                    hs.DeleteObject(MaterialList[i]);
                }

                return hs.SaveChanges();
            }
        }

        //查询所有
        public static List<MaterialCls> GetAll()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<MaterialCls> macls = new List<MaterialCls>();

                List<Material> MaterialList = hs.MaterialSet.Where(m => m.Id >= 0).ToList();

                foreach(var item in MaterialList)
                {
                    macls.Add(new MaterialCls
                    {
                        Id=item.Id,
                        MaterialName=item.MaterialName,
                        ElasticModulus=item.ElasticModulus,
                        TensileStrength=item.TensileStrength,
                        YieldSrength=item.YieldSrength,
                        UltimateElongation=item.UltimateElongation,
                        ReductionOfArea=item.ReductionOfArea,
                        HardenablityValue=item.HardenablityValue,
                        StrainOfWidthAndThickness=item.StrainOfWidthAndThickness
                    });
                }

                return macls;
            }
        }
    }
}
