using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;

namespace HullShellTest.DAL
{
    public class DetectEquipmentDAL
    {
        //增加检测设备信息
        public static int AddDetectEquipment(DetectEquipmentCls dec)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                DetectEquipment de = new DetectEquipment
                {
                    DetectEquipmentName = dec.MeasureDeviceName,
                    CameraResolution = dec.CameraResolution,
                    PixelSize = dec.PixelSize,
                    StdPrecision = dec.StdPrecision
                };

                hs.AddToDetectEquipmentSet(de);

                return hs.SaveChanges();

            }
        }

        //删除检测设备信息,根据软件名字删除
        public static int DeleteDetectEuipmentByName(string Name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                DetectEquipment de = hs.DetectEquipmentSet.Where(d => d.DetectEquipmentName == Name).FirstOrDefault();
                hs.DeleteObject(de);

                return hs.SaveChanges();
            }
        }

        //根据索引删除检测设备
        public static int DeleteDetectEuipmentById(int Id)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                DetectEquipment de = hs.DetectEquipmentSet.Where(d => d.Id == Id).FirstOrDefault();
                hs.DeleteObject(de);

                return hs.SaveChanges();
            }
        }

        //修改
        public static int ModifyDetectEquipmentByName(DetectEquipmentCls dec)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                DetectEquipment de = hs.DetectEquipmentSet.Where(d => d.DetectEquipmentName == dec.MeasureDeviceName).FirstOrDefault();

                de.DetectEquipmentName = dec.MeasureDeviceName;
                de.CameraResolution = dec.CameraResolution;
                de.PixelSize = dec.PixelSize;
                de.StdPrecision = dec.StdPrecision;

                return hs.SaveChanges();
            }
        }

        //修改
        public static int ModifyDetectEquipmentById(DetectEquipmentCls dec)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                DetectEquipment de = hs.DetectEquipmentSet.Where(d => d.Id== dec.Id).FirstOrDefault();

                de.DetectEquipmentName = dec.MeasureDeviceName;
                de.CameraResolution = dec.CameraResolution;
                de.PixelSize = dec.PixelSize;
                de.StdPrecision = dec.StdPrecision;

                return hs.SaveChanges();
            }
        }

        //查询,根据名字
        public static DetectEquipmentCls QueryDetectEquipmentByName(string _name)
        {
            using (HullShellContainer hs = new HullShellContainer())
            {
                DetectEquipment de = hs.DetectEquipmentSet.Where(d => d.DetectEquipmentName == _name).FirstOrDefault();

                DetectEquipmentCls dec = new DetectEquipmentCls();
                dec.Id = de.Id;
                dec.MeasureDeviceName = de.DetectEquipmentName;
                dec.CameraResolution = de.CameraResolution;
                dec.PixelSize = de.PixelSize;
                dec.StdPrecision = de.StdPrecision;

                return dec;
            }
        }

        //清空
        public int ClearDetectEquipment()
        {

            using (HullShellContainer hs = new HullShellContainer())
            {

                List<DetectEquipment> DeList = hs.DetectEquipmentSet.Where(d => d.Id >= 0).ToList();

                for (int i = 0; i < DeList.Count; i++)
                {
                    hs.DeleteObject(DeList[i]);
                }

                return hs.SaveChanges();

            }

        }

        //查询全部
        public static List<DetectEquipmentCls> GetAllDetectEquipments()
        {
            List<DetectEquipmentCls> decList = new List<DetectEquipmentCls>();
            using (HullShellContainer hs = new HullShellContainer())
            {
                List<DetectEquipment> deList = hs.DetectEquipmentSet.Where(d => d.Id > 0).ToList();

                for (int i = 0; i < deList.Count;i++ )
                {
                    decList.Add(new DetectEquipmentCls
                    { 
                        Id=deList[i].Id,
                        MeasureDeviceName=deList[i].DetectEquipmentName,
                        CameraResolution=deList[i].CameraResolution,
                        PixelSize=deList[i].PixelSize,
                        StdPrecision=deList[i].StdPrecision
                    });
                }

                return decList;                
            }
        }


    }
}
