using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HullShellTest.ModelData;
using System.IO;

namespace HullShellTest.Utils
{
    public class ReadFile
    {
        public ReadFile()
        {
        }

        public static TheoryPointsCls ReadStdPts(string FileName)
        {
            TheoryPointsCls PtTheory = new TheoryPointsCls();
            string TheoryFileName;

            FileStream PointsFile = File.Open(FileName, FileMode.Open);
            StreamReader sw = new StreamReader(PointsFile);

            string strLine;
            string[] strArray;
            char[] charArray = new char[] { ' ' };

            while ((strLine = sw.ReadLine()) != null)
            {
                if (strLine == "standard")
                {
                    PtTheory.ColnumNumber = 50;
                    PtTheory.RowNumberow = 50;

                    strLine = sw.ReadLine();
                    PtTheory.TheoryPlateName = strLine;

                    continue;
                }
                else
                    if (strLine == "cloud_start")
                    {
                        while ((strLine = sw.ReadLine()) != "cloud_end")
                        {
                            strArray = strLine.Split(' ');
                            PointCls ptcls = new PointCls(Convert.ToDouble(strArray[0]), Convert.ToDouble(strArray[1]), Convert.ToDouble(strArray[2]));
                            PtTheory.PointsCloudList.Add(ptcls);
                        }
                        continue;
                    }
                    else
                        if (strLine == "edgeEdge_start")
                        {
                            while ((strLine = sw.ReadLine()) != "edgeEdge_end")
                            {
                                strArray = strLine.Split(' ');
                                PointCls ptcls = new PointCls(Convert.ToDouble(strArray[0]), Convert.ToDouble(strArray[1]), Convert.ToDouble(strArray[2]));
                                PtTheory.EdgeEdgePointsList.Add(ptcls);
                            }
                            continue;
                        }
                        else
                            if (strLine == "excess_start")
                            {
                                while ((strLine = sw.ReadLine()) != "excess_end")
                                {
                                    strArray = strLine.Split(' ');
                                    PointCls ptcls = new PointCls(Convert.ToDouble(strArray[0]), Convert.ToDouble(strArray[1]), Convert.ToDouble(strArray[2]));
                                    PtTheory.ExcessPointsList.Add(ptcls);
                                }
                                continue;
                            }
                            else
                                if (strLine == "frame_start")
                                {
                                    while ((strLine = sw.ReadLine()) != "frame_end")
                                    {
                                        strArray = strLine.Split(' ');
                                        PointCls ptcls = new PointCls(Convert.ToDouble(strArray[0]), Convert.ToDouble(strArray[1]), Convert.ToDouble(strArray[2]));
                                        PtTheory.RiblinePointsList.Add(ptcls);
                                    }
                                    continue;
                                }
            }

            sw.Close();
            PointsFile.Close();

            return PtTheory;
        }

        public static ScanPointsCls ReadScanPts(string FileName)
        {
            ScanPointsCls ScanPts = new ScanPointsCls();

            string ScanFilesName;

            FileStream PointsFile = File.Open(FileName, FileMode.Open);
            StreamReader sw = new StreamReader(PointsFile);

            string strLine;
            string[] strArray;
            char[] charArray = new char[] { ' ' };

            while ((strLine = sw.ReadLine()) != null)
            {
                if (strLine == "scan")
                {
                    continue;
                }
                else
                    if (strLine == "cloud_start")
                    {
                        while ((strLine = sw.ReadLine()) != "cloud_end")
                        {
                            strArray = strLine.Split(' ');
                            PointCls ptcls = new PointCls(Convert.ToDouble(strArray[0]), Convert.ToDouble(strArray[1]), Convert.ToDouble(strArray[2]));
                            ScanPts.SPList.Add(ptcls);
                        }

                        continue;
                    }
                    else
                        if (strLine == "cloud_end")
                        {
                            //break;
                        }
            }

            PointsFile.Close();
            sw.Close();

            return ScanPts;
        }

        public static Dictionary<int, List<string>> ReadProcessFile(string FileName)
        {
            Dictionary<int, List<string>> dicLine = new Dictionary<int, List<string>>();

            FileStream PointsFile = File.Open(FileName, FileMode.Open);
            StreamReader sw = new StreamReader(PointsFile);

            string strLine;
            string[] strArray;
            char[] charArray = new char[] { ',' };

            int i = 1;

            while ((strLine=sw.ReadLine()) != null)
            {
                strArray = strLine.Split(charArray);
                List<string> strList = new List<string>();
                foreach(var item in strArray)
                {
                    strList.Add(item);
                }

                dicLine.Add(i, strList);

                i++;

            }

            PointsFile.Close();
            sw.Close();

            return dicLine;
        }


        //public  ReadPtCloudFile(string FileName)
        //{

        //}

        //string CurrentDir = Application.StartupPath;
        //  string FileName = CurrentDir + "//ScanPoint.asc";
        //  FileStream PointsFile = File.Open(FileName,FileMode.Create);
        //  StreamWriter sw = new StreamWriter(PointsFile);

        //  var sheet = gridDesktop1.GetActiveWorksheet();
        //  for (int i = 0; i < sheet.RowsCount; i++)
        //  {
        //      if (string.IsNullOrEmpty(sheet.Cells[i, 0].StringValue))
        //      {
        //          continue;
        //      }
        //      //string line = i + ","+sheet.Cells[i, 0].Value + "," + sheet.Cells[i, 1].Value + "," + sheet.Cells[i, 2].Value+"\r\n";
        //      string line = sheet.Cells[i, 0].Value + " " + sheet.Cells[i, 1].Value + " " + sheet.Cells[i, 2].Value + "\r\n";
        //      DataCoor TempCoor = new DataCoor();
        //      TempCoor.x = Convert.ToString(sheet.Cells[i, 0].Value);
        //      TempCoor.y = Convert.ToString(sheet.Cells[i, 1].Value);
        //      TempCoor.z = Convert.ToString(sheet.Cells[i, 2].Value);
        //      _Coor.Add(TempCoor);
        //  }

        //  sw.WriteLine("scan");
        //  sw.WriteLine("scan");
        //  sw.WriteLine("cloud_start");

        //  int PointCount=_Coor.Count;
        //  if (PointCount == 0)
        //  {
        //      sw.WriteLine("cloud_end");
        //      sw.WriteLine("startPoint");
        //      sw.WriteLine("startPoint_end");
        //      sw.WriteLine("endPoint");
        //      sw.WriteLine("endPoint_end");
        //  }
        //  else
        //  {
        //      for (int i = 0; i < _Coor.Count; i++)
        //      {
        //          string PointStr = _Coor[i].x + " " + _Coor[i].y + " " + _Coor[i].z;
        //          sw.WriteLine(PointStr);
        //      }
        //      sw.WriteLine("cloud_end");
        //      sw.WriteLine("startPoint");
        //      string startPointStr = _Coor[0].x + " " + _Coor[0].y + " " + _Coor[0].z+" "+0+" "+255+" "+0+" "+255;
        //      sw.WriteLine(startPointStr);
        //      sw.WriteLine("startPoint_end");

        //      sw.WriteLine("endPoint");
        //      string endPointStr = _Coor[PointCount - 1].x + " " + _Coor[PointCount - 1].y + " " + _Coor[PointCount - 1].z+" "+255+" "+0+" "+0+" "+255;
        //      sw.WriteLine(endPointStr);
        //      sw.WriteLine("endPoint_end");

        //  }

        //  sw.Close();

        //  MessageBox.Show("测量点云导出成功！");

    }
}
