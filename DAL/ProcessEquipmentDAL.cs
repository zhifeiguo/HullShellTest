using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.DAL
{
    public class ProcessEquipmentDAL
    {
        //增加
        public static int AddProcessEquipment(ProcessEquipmentCls pec)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ProcessingEquipment pe = new ProcessingEquipment
                {
                    EquipMentName=pec.ProcessEquipmentName,
                    PressureHeadLength=pec.PressureHeadLength,
                    DriveMode=pec.DirverMode,
                    HeadNumberOfDownDie=pec.DownDieHeadNumber,
                    HeadNumberOfUpDie=pec.UpDieHeadNumber
                };

                hs.AddToProcessingEquipmentSet(pe);

                return hs.SaveChanges();

            }
        }

        //删除
        public static int DeleteProcessEquipmentByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ProcessingEquipment pe = hs.ProcessingEquipmentSet.Where(p => p.EquipMentName == _name).FirstOrDefault();
                hs.DeleteObject(pe);

                return hs.SaveChanges();

            }
        }

        public static int DeleteProcessEquipmentById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ProcessingEquipment pe = hs.ProcessingEquipmentSet.Where(p => p.Id == Id).FirstOrDefault();
                hs.DeleteObject(pe);

                return hs.SaveChanges();

            }
        }

        //修改
        public static int ModifyProcessEquipmentByName(ProcessEquipmentCls pec)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ProcessingEquipment pe = hs.ProcessingEquipmentSet.Where(p=>p.EquipMentName==pec.ProcessEquipmentName).FirstOrDefault();

                pe.EquipMentName = pec.ProcessEquipmentName;
                pe.PressureHeadLength = pec.PressureHeadLength;
                pe.DriveMode = pec.DirverMode;
                pe.HeadNumberOfUpDie = pec.UpDieHeadNumber;
                pe.HeadNumberOfDownDie = pec.DownDieHeadNumber;

                return hs.SaveChanges();

            }

        }

        public static int ModifyProcessEquipmentById(ProcessEquipmentCls pec)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ProcessingEquipment pe = hs.ProcessingEquipmentSet.Where(p => p.Id == pec.Id).FirstOrDefault();

                pe.EquipMentName = pec.ProcessEquipmentName;
                pe.PressureHeadLength = pec.PressureHeadLength;
                pe.DriveMode = pec.DirverMode;
                pe.HeadNumberOfUpDie = pec.UpDieHeadNumber;
                pe.HeadNumberOfDownDie = pec.DownDieHeadNumber;

                return hs.SaveChanges();

            }

        }

        //查询
        public static ProcessEquipmentCls QueryProcessEquipmentByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ProcessingEquipment pe = hs.ProcessingEquipmentSet.Where(p => p.EquipMentName == _name).FirstOrDefault();

                ProcessEquipmentCls pec=new ProcessEquipmentCls();

                pec.Id = pe.Id;
                pec.ProcessEquipmentName=pe.EquipMentName;
                pec.PressureHeadLength=pe.PressureHeadLength;
                pec.DirverMode=pe.DriveMode;
                pec.DownDieHeadNumber=pe.HeadNumberOfDownDie;
                pec.UpDieHeadNumber=pe.HeadNumberOfUpDie;

                return pec;

            }
        }

        public static ProcessEquipmentCls QueryProcessEquipmentById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                ProcessingEquipment pe = hs.ProcessingEquipmentSet.Where(p => p.Id == Id).FirstOrDefault();

                ProcessEquipmentCls pec = new ProcessEquipmentCls();

                pec.Id = pe.Id;
                pec.ProcessEquipmentName = pe.EquipMentName;
                pec.PressureHeadLength = pe.PressureHeadLength;
                pec.DirverMode = pe.DriveMode;
                pec.DownDieHeadNumber = pe.HeadNumberOfDownDie;
                pec.UpDieHeadNumber = pe.HeadNumberOfUpDie;

                return pec;

            }
        }


        //清空
        public static int ClearProcessEquipment()
        {

            using (HullShellContainer hs = new HullShellContainer())
            {

                List<ProcessingEquipment> PeList = hs.ProcessingEquipmentSet.Where(p => p.Id >= 0).ToList();

                for (int i = 0; i < PeList.Count; i++)
                {
                    hs.DeleteObject(PeList[i]);
                }

                return hs.SaveChanges();


            }

        }

        public static List<ProcessEquipmentCls>  GetAll()
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<ProcessEquipmentCls> pecls = new List<ProcessEquipmentCls>();

                List<ProcessingEquipment> pe = hs.ProcessingEquipmentSet.Where(p => p.Id > 0).ToList();

                foreach(var item in pe)
                {
                    pecls.Add(new ProcessEquipmentCls
                    {
                        Id=item.Id,
                        ProcessEquipmentName=item.EquipMentName,
                        PressureHeadLength=item.PressureHeadLength,
                        DirverMode=item.DriveMode,
                        UpDieHeadNumber=item.HeadNumberOfUpDie,
                        DownDieHeadNumber=item.HeadNumberOfDownDie
                    });
                }

                return pecls;

            }
        }


    }
}
