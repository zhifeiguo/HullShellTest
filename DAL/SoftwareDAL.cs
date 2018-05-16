using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.DAL
{
    public class SoftwareDAL
    {
        //增加软件信息
        public static int AddSoftware(SoftWareCls sw)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Software sf = new Software { SoftwareName = sw.SoftWareName,
                RegisterAlgorithm = sw.RegisterAlgorithm,
                DiffComputer = sw.DiffComputer,
                SurfaceReconstruction = sw.SurfaceReconstruction };

                hs.AddToSoftwareSet(sf);

                return hs.SaveChanges();
            }
        }

        //删除软件信息,根据软件名字删除
        public static int DeleteSoftwareByName(string Name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Software sf = hs.SoftwareSet.Where(s => s.SoftwareName == Name).FirstOrDefault();
                hs.DeleteObject(sf);

                return hs.SaveChanges();
            }
        }
        //根据id删除
        public static int DeleteSoftwareById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Software sf = hs.SoftwareSet.Where(s => s.Id == Id).FirstOrDefault();
                hs.DeleteObject(sf);

                return hs.SaveChanges();
            }
        }

        //修改
        public static int ModifySoftWareByName(SoftWareCls sw)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Software sf = hs.SoftwareSet.Where(s => s.SoftwareName == sw.SoftWareName).FirstOrDefault();

                sf.SoftwareName = sw.SoftWareName;
                sf.RegisterAlgorithm = sw.RegisterAlgorithm;
                sf.DiffComputer = sw.DiffComputer;
                sf.SurfaceReconstruction = sw.SurfaceReconstruction;

                return hs.SaveChanges();
            }
        }
        //根据Id修改
        public static int ModifySoftWareById(SoftWareCls sw)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Software sf = hs.SoftwareSet.Where(s => s.Id == sw.Id).FirstOrDefault();

                sf.SoftwareName = sw.SoftWareName;
                sf.RegisterAlgorithm = sw.RegisterAlgorithm;
                sf.DiffComputer = sw.DiffComputer;
                sf.SurfaceReconstruction = sw.SurfaceReconstruction;

                return hs.SaveChanges();
            }
        }

        //查询根据名字查询
        public static SoftWareCls QuerySoftWareByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Software sf = hs.SoftwareSet.Where(s => s.SoftwareName == _name).FirstOrDefault();

                SoftWareCls sw = new SoftWareCls();
                sw.Id = sf.Id;
                sw.SoftWareName = sf.SoftwareName;
                sw.RegisterAlgorithm = sf.RegisterAlgorithm;
                sw.DiffComputer = sf.DiffComputer;
                sw.SurfaceReconstruction = sf.SurfaceReconstruction;

                return sw;
            }
        }

        //查询，根据Id查询
        public static SoftWareCls QuerySoftWareById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Software sf = hs.SoftwareSet.Where(s => s.Id == Id).FirstOrDefault();

                SoftWareCls sw = new SoftWareCls();
                sw.Id = sf.Id;
                sw.RegisterAlgorithm = sf.RegisterAlgorithm;
                sw.DiffComputer = sf.DiffComputer;
                sw.SurfaceReconstruction = sf.SurfaceReconstruction;

                return sw;
            }
        }

        //获得所有记录
        public static List<SoftWareCls> GetAllSoftware()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<SoftWareCls> adc = new List<SoftWareCls>();

                List<Software> SfList = hs.SoftwareSet.Where(s => s.Id >= 0).ToList();

                foreach (var item in SfList)
                {
                    adc.Add(new SoftWareCls { Id = item.Id,
                    SoftWareName = item.SoftwareName,
                    RegisterAlgorithm = item.RegisterAlgorithm,
                    DiffComputer = item.DiffComputer,
                    SurfaceReconstruction = item.SurfaceReconstruction });
                }

                return adc;
            }
        }

        //清空
        public static int ClearSoftware()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<Software> SfList = hs.SoftwareSet.Where(s => s.Id >= 0 ).ToList();

                for (int i = 0; i < SfList.Count; i++)
                {
                    hs.DeleteObject(SfList[i]);
                }

                return hs.SaveChanges();
            }
        }
    }
}
