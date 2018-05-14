using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HullShellTest.DAL;
using HullShellTest.ModelData;
using DevExpress.XtraEditors;
using HullShellTest.ModelData.Extent;
using HullShellTest.Utils;

namespace HullShellTest.UI
{
    public partial class StdHullFrm : TemplateFrm
    {
        public StdHullFrm()
        {
            InitializeComponent();

            StdHullCls = new StdHullShellCls();
            StdHullClsList = new List<StdHullShellCls>();

            StdHullBis = new StdHullBasicInformationCls();
            StdHullBisList = new List<StdHullBasicInformationCls>();

            tPtsCls = new TheoryPointsCls();
            sPtsCls = new ScanPointsCls();

            PtsDir = new PointCls();
            MaxPnt = new PointCls();
            MinPnt = new PointCls();

            init_cmbBox();

            init_cmbBox_MaterialName();

            this.layoutControlGroup1.Enabled = false;
            //this.layoutControlGroup2.Enabled = false;

            this.layoutControlGroup3.Enabled = false;
            this.layoutControlGroup4.Enabled = false;

            this.txtPointRow.Enabled = false;
            this.txtPointsCloumn.Enabled = false;

            if (this.cmbObjectList.Items.Count == 0)
            {
                MessageBox.Show("数据库中不存在理论曲版！");
            }

        }

        //理论曲版
        public StdHullShellCls StdHullCls;
        public List<StdHullShellCls> StdHullClsList;

        //曲版基本信息
        public StdHullBasicInformationCls StdHullBis;
        public List<StdHullBasicInformationCls> StdHullBisList;

        //理论点
        public TheoryPointsCls tPtsCls;

        //测量点
        public ScanPointsCls sPtsCls;

        //包围盒属性
        public PointCls PtsDir;
        public PointCls MinPnt;
        public PointCls MaxPnt;

        //下拉框初始化
        public bool init_cmbBox()
        {
            try
            {
                this.cmbObjectList.Items.Clear();
                StdHullBisList = StdHullShellDAL.GetAllStdHullShell();

                foreach (var val in StdHullBisList)
                {
                    this.cmbObjectList.Items.Add(val.PlateModel);
                }
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool init_cmbBox_MaterialName()
        {
            try
            {                
                this.cbxMaterialName.Items.Clear();
                List<MaterialCls>  mtcls  = MaterialDAL.GetAll();

                foreach (var val in mtcls)
                {
                    this.cbxMaterialName.Items.Add(val.MaterialName);
                }
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return true;
        }

        //查询所有
        public override bool QueryAll()
        {
            try
            {
                StdHullBisList = StdHullShellDAL.GetAllStdHullShell();

                StdHullBindingSource.DataSource = StdHullBisList;
                this.gridControl1.DataSource = StdHullBindingSource;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        private void btn_OpenStdPoints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";//注意这里写路径时要用c:\\而不是c:\
            //openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.Filter = "点云文件|*.asc|文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            string fName=null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;

                tPtsCls = ReadFile.ReadStdPts(fName);
                this.cbxStdPoints.SelectedIndex = 0;
                #region
                //File fileOpen = new File(fName);
                //isFileHaveName = true;
                //richTextBox1.Text = fileOpen.ReadFile();
                //richTextBox1.AppendText("");\
                #endregion
            }

            PtsBindingSource.DataSource = tPtsCls.PointsCloudList;
            gridControl2.DataSource = PtsBindingSource;

            this.textPlateName.Text = tPtsCls.TheoryPlateName;



            this.dpPointsCloud.Show();
        }

        private void btn_OpenScanPts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";//注意这里写路径时要用c:\\而不是c:\
            //openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.Filter = "点云文件|*.asc|文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            string fName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;

                sPtsCls = ReadFile.ReadScanPts(fName);
            }


            ScanPointsBindingSource.DataSource = sPtsCls.SPList;
            gridControl3.DataSource = ScanPointsBindingSource;

            this.dpScanPoints.Show();
        }

        private void btn_OpenProcessFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";//注意这里写路径时要用c:\\而不是c:\
            //openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.Filter = "点云文件|*.asc|文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            string fName;

            Dictionary<int, List<string>> dicLine = new Dictionary<int, List<string>>();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;

                dicLine = ReadFile.ReadProcessFile(fName);
            }

            this.PtsDir.x = Convert.ToDouble(dicLine[1][0]);
            this.PtsDir.y = Convert.ToDouble(dicLine[1][1]);
            this.PtsDir.z = Convert.ToDouble(dicLine[1][2]);

            this.MinPnt.x = Convert.ToDouble(dicLine[2][0]);
            this.MinPnt.y = Convert.ToDouble(dicLine[2][1]);
            this.MinPnt.z = Convert.ToDouble(dicLine[2][2]);

            this.MaxPnt.x = Convert.ToDouble(dicLine[3][0]);
            this.MaxPnt.y = Convert.ToDouble(dicLine[3][1]);
            this.MaxPnt.z = Convert.ToDouble(dicLine[3][2]);

            txtDir.Text = FormateString(PtsDir);
            txtMin.Text = FormateString(MinPnt);
            txtMax.Text = FormateString(MaxPnt);


            this.dpOtherInfo.Show();

        }

        private string FormateString(PointCls ptcls)
        {
            string reStr='('+ptcls.x.ToString()+','+ptcls.y.ToString()+','+ptcls.z.ToString()+')';

            return reStr;

        }

        private void cbxStdPoints_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxStdPoints_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tPtsCls.PointsCloudList.Count()==0)
            {
                MessageBox.Show("请打开理论点云文件！");
                return;
            }

            string strValue = this.cbxStdPoints.EditValue.ToString();

            if (strValue== "理论点云")
            {
                PtsBindingSource.DataSource = tPtsCls.PointsCloudList;
                gridControl2.DataSource = PtsBindingSource;

                this.txtPointRow.Text = tPtsCls.RowNumberow.ToString();
                this.txtPointsCloumn .Text= tPtsCls.ColnumNumber.ToString();
            }
            else if (strValue == "余量点云")
            {
                PtsBindingSource.DataSource = tPtsCls.ExcessPointsList;
                gridControl2.DataSource = PtsBindingSource;

                this.txtPointRow.Text = "";
                this.txtPointsCloumn.Text = "";

            }
            else if (strValue == "边边交点")
            {
                PtsBindingSource.DataSource = tPtsCls.EdgeEdgePointsList;
                gridControl2.DataSource = PtsBindingSource;

                this.txtPointRow.Text = "";
                this.txtPointsCloumn.Text = "";
            }
            else
            {
                PtsBindingSource.DataSource = tPtsCls.RiblinePointsList;
                gridControl2.DataSource = PtsBindingSource;

                this.txtPointRow.Text = "";
                this.txtPointsCloumn.Text = "";
            }

        }

        //增加
        public override bool AddData()
        {
            try
            {
                this.layoutControlGroup1.Enabled = true;
                this.layoutControlGroup4.Enabled = true;
                
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //保存
        //需要增加提示控件为空的程序
        public override bool SaveDataA()
        {
            try
            {
                if (AddorModify == AddOrModifyEnum.Add)
                {
                    StdHullCls = new StdHullShellCls();

                    //添加基本信息
                    StdHullBis = new StdHullBasicInformationCls();

                    StdHullBis.PlateModel = this.textPlateName.Text.ToString();
                    StdHullBis.Thickness = Convert.ToInt32(this.textThickness.Text.ToString());
                    StdHullBis.Width1 = Convert.ToInt32(this.textWidth1.Text.ToString());
                    StdHullBis.Width2 = Convert.ToInt32(this.textWidth2.Text.ToString());
                    StdHullBis.Length1 = Convert.ToInt32(this.textLength1.Text.ToString());
                    StdHullBis.Length2 = Convert.ToInt32(this.textLength2.Text.ToString());
                    StdHullBis.TransverseCurvate = Convert.ToInt32(this.textCurve1.Text.ToString());
                    StdHullBis.LongitudinalCurvature = Convert.ToInt32(this.textCurve2.Text.ToString());
                    StdHullBis.SideCount = Convert.ToInt32(this.textEdgeCount.Text.ToString());
                    StdHullBis.RiblineCount = Convert.ToInt32(this.textRiblineCount.Text.ToString());
                    StdHullBis.ShipName = this.textShipName.Text.ToString();
                    StdHullBis.MaterialName = this.cbxMaterialName.Text.ToString();
                    StdHullBis.CurvePlateKind = this.textPlateMode.Text.ToString();

                    StdHullCls.StdHullBasicInfo = StdHullBis;

                    //添加回弹属性
                    ResilienceFactorCls rfcls = new ResilienceFactorCls();
                    rfcls.Curvature = Convert.ToDouble(this.txtCurve.Text.ToString());
                    rfcls.CurvatureRange = Convert.ToDouble(this.txtCurveRange.Text.ToString());
                    rfcls.ResilienCoefficient = Convert.ToDouble(this.txtResilienceFactor.Text.ToString());
                    rfcls.WidthRange = Convert.ToDouble(this.txtWidthRange.Text.ToString());

                    StdHullCls.rfc = rfcls;

                    //添加理论点云
                    StdHullCls.tpc = this.tPtsCls;

                    //添加包围盒
                    StdHullCls.Dir = this.PtsDir;
                    StdHullCls.Pt_Max = this.MaxPnt;
                    StdHullCls.Pt_Min = this.MinPnt;

                    int re = StdHullShellDAL.AddStdHullShell(StdHullCls);

                    if (re > 0)
                    {
                        StdHullBindingSource.DataSource = StdHullBis;
                        this.gridControl1.DataSource = StdHullBindingSource;

                        this.layoutControlGroup1.Enabled = false;
                        this.layoutControlGroup4.Enabled = false;

                        this.textPlateName.Text="";
                        this.textThickness.Text = "";
                        this.textWidth1.Text = "";
                        this.textWidth1.Text = "";
                        this.textWidth2.Text = "";
                        this.textLength1.Text = "";
                        this.textLength2.Text = "";
                        this.textCurve1.Text = "";
                        this.textCurve1.Text = "";
                        this.textCurve2.Text = "";
                        this.textEdgeCount.Text = "";
                        this.textEdgeCount.Text = "";
                        this.textRiblineCount.Text = "";
                        this.textShipName.Text = "";
                        this.cbxMaterialName.Text = "";
                        this.textPlateMode.Text = "";

                        this.txtCurve.Text = "";
                        this.txtCurveRange.Text = "";
                        this.txtResilienceFactor.Text = "";
                        this.txtWidthRange.Text = "";

                        init_cmbBox();

                        MessageBox.Show("加工设备信息增加成功！");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("加工设备增加失败！");

                        return false;
                    }
                }
                else if (AddorModify == AddOrModifyEnum.Modify)
                {
        //            pecls.ProcessEquipmentName = this.textEquipmentName.Text.ToString();
        //            pecls.DirverMode = this.txtDriveMode.Text.ToString();
        //            pecls.PressureHeadLength = Convert.ToInt32(this.txtPressureSize.Text.ToString());
        //            pecls.UpDieHeadNumber = Convert.ToInt32(this.txtUpCount.Text.ToString());
        //            pecls.DownDieHeadNumber = Convert.ToInt32(this.txtDownCount.Text.ToString());

        //            ProcessEquipmentDAL.ModifyProcessEquipmentById(pecls);

        //            this.layoutControlGroup1.Enabled = false;

        //            init_cmbBox();


                    return true;
                }
                else
                {
                    MessageBox.Show("理论曲板设备添加/修改失败！");
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("加工设备添加失败：" + ex.Message.ToString()+"!");
                return false;
            }
        }

        ////删除
        //public override bool DeleteData()
        //{
        //    try
        //    {
        //        if (XtraMessageBox.Show("是否删除选中的数据？", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //        {

        //            pecls = new ProcessEquipmentCls();

        //            int[] rows = gridView1.GetSelectedRows();

        //            for (int i = 0; i < rows.Length; i++)
        //            {
        //                pecls = (ProcessEquipmentCls)gridView1.GetRow(rows[i]);
        //                ProcessEquipmentDAL.DeleteProcessEquipmentById(pecls.Id);
        //            }
        //        }

        //        //QueryAll();

        //        init_cmbBox();

        //        return true;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return false;
        //    }


        //    //return base.DeleteData();
        //}

        //public override bool RefreshData()
        //{
        //    try
        //    {
        //        string UserName = this.ItemObjectList.EditValue.ToString();

        //        ProcessEquipmentCls val = ProcessEquipmentDAL.QueryProcessEquipmentByName(UserName);

        //        ProcessEquipmentBindingSource.DataSource = val;

        //        gridControl1.DataSource = ProcessEquipmentBindingSource;

        //        return true;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return false;
        //    }
        //}

        ////修改
        public override bool ModifyData()
        {
            try
            {
                this.layoutControlGroup1.Enabled = true;
                this.layoutControlGroup4.Enabled = true;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        ////选择记录
        //public override bool SelectRecord()
        //{
        //    try
        //    {
        //        pecls = new ProcessEquipmentCls();

        //        int[] rows = gridView1.GetSelectedRows();
        //        pecls = (ProcessEquipmentCls)gridView1.GetRow(rows[0]);

        //        textEquipmentName.Text = pecls.ProcessEquipmentName;
        //        txtDriveMode.Text = pecls.DirverMode;
        //        txtPressureSize.Text = pecls.PressureHeadLength.ToString();
        //        txtDownCount.Text = pecls.DownDieHeadNumber.ToString();
        //        txtUpCount.Text = pecls.UpDieHeadNumber.ToString();

        //        return true;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return false;
        //    }
        //}



    }
}
