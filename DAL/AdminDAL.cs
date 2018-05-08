using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.DAL
{
    public class AdminsDAL
    {
        //增加
        public static int AddAdmin(AdminsCls adc)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Admins adm = new Admins
                {
                    UserName=adc.UserName,
                    PassWod=adc.PassWord,
                    Role=adc.Role
                };

                hs.AddToAdminsSet(adm);

                return hs.SaveChanges();
            }
        }

        //删除
        public static int DeleteAdminsByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Admins adm = hs.AdminsSet.Where(a => a.UserName == _name).FirstOrDefault();
                hs.DeleteObject(adm);

                return hs.SaveChanges();

            }
        }

        public static int DeleteAdminsById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Admins adm = hs.AdminsSet.Where(a => a.Id == Id).FirstOrDefault();
                hs.DeleteObject(adm);

                return hs.SaveChanges();

            }
        }

        //修改
        public static int ModifyAdmins(AdminsCls adc)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Admins adm = hs.AdminsSet.Where(a => a.Id == adc.Id).FirstOrDefault();

                adm.UserName=adc.UserName;
                adm.PassWod=adc.PassWord;
                adm.Role=adc.Role;

                return hs.SaveChanges();
            }
        }

        //查询
        public static AdminsCls QueryAdmin(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                Admins adm = hs.AdminsSet.Where(a => a.UserName == _name).FirstOrDefault();

                AdminsCls adc = new AdminsCls();
                adc.Id=adm.Id;
                adc.UserName=adm.UserName;
                adc.PassWord = adm.PassWod;
                adc.Role=adm.Role;

                return adc;
            }
        }

        //清空
        public static int ClearAdmins()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<Admins> AdmList = hs.AdminsSet.Where(a => a.Id >= 0).ToList();

                for (int i = 0; i < AdmList.Count; i++)
                {
                    hs.DeleteObject(AdmList[i]);
                }

                return hs.SaveChanges();
            }

        }

        //获得所有的用户
        public static List<Admins> GetAllAdmins()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<Admins> val = hs.AdminsSet.Where(a => a.Id >= 0).ToList();

                return val;
            }
        }


        //获得所有的用户
        public static List<AdminsCls> GetAllAdminsCls()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {

                List<AdminsCls> adcList = new List<AdminsCls>();
                List<Admins> val = hs.AdminsSet.Where(a => a.Id >= 0).ToList();

                foreach (var item in val)
                {
                    AdminsCls adc = new AdminsCls
                    {
                        Id=item.Id,
                        UserName=item.UserName,
                        PassWord=item.PassWod,
                        Role=item.Role

                    };

                    adcList.Add(adc);
                }

                return adcList;
            }
        }

    }
}
