using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HullShellTest.ModelData;
using HullShellTest.DAL;
using HullShellTest.ModelData.Extent;
using DevExpress.XtraTreeList.Nodes;

namespace HullShellTest.UI
{
    public enum ObjectEnum
    {
        Admin=1,
        DetectEquipment=2,
        Material=3,
        ProcessEquipment=4,
        Software=5,
    }

    public partial class ProcessParameterFrm : TemplateFrm
    {
         public ProcessParameterFrm()
        {
            InitializeComponent();

            init_cmbBox(ObjectEnum.Admin);
            init_cmbBox(ObjectEnum.DetectEquipment);
            init_cmbBox(ObjectEnum.Software);
            init_cmbBox(ObjectEnum.ProcessEquipment);

            this.cbxSoftwareInfo.Text = "";
            this.cbxMeasureDevice.Text = "";
            this.cbxProcessEquipment.Text = "";
            this.cbxWorker.Text = "";

            init_TreeList();
            AddtreelistNode();
        }

         public List<StdHull> StdHullList=new List<StdHull>();

        private void init_TreeList()
        {
            //初始化理论曲板列表
            DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnOrder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            treeListColumnOrder.Caption = "序号";
            treeListColumnOrder.FieldName = "ID";
            treeListColumnOrder.MinWidth = 25;
            treeListColumnOrder.Name = "treeListColumnOrder";
            treeListColumnOrder.Visible = true;
            treeListColumnOrder.VisibleIndex = 0;
            treeListColumnOrder.Width = 50;

            DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnStdHull = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            treeListColumnStdHull.Caption = "理论曲板名称";
            //treeListColumnStdHull.ColumnEdit = this.repositoryItemCheckEdit1;
            treeListColumnStdHull.FieldName = "StdHullName";
            treeListColumnStdHull.Name = "treeListColumnStdHull";
            treeListColumnStdHull.Visible = true;
            treeListColumnStdHull.VisibleIndex = 1;
            treeListColumnOrder.MinWidth = 38;
            treeListColumnOrder.Width = 111;

            #region
            //DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnStatisticValue = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            //treeListColumnStatisticValue.Caption = "选择";
            ////treeListColumnStatisticValue.ColumnEdit = DevExpress.XtraEditors.CheckEdit;
            //treeListColumnStatisticValue.FieldName = "IsChecked";
            //treeListColumnStatisticValue.Name = "treeListColumnStatisticValue";
            //treeListColumnStatisticValue.Visible = true;
            //treeListColumnStatisticValue.VisibleIndex = 1;
            #endregion

            this.treeListStdHullName.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
                treeListColumnOrder,treeListColumnStdHull});
            this.treeListStdHullName.Nodes.Clear();
            this.treeListStdHullName.Refresh();

            this.treeListStdHullName.OptionsView.AutoWidth = true;
            this.treeListStdHullName.OptionsView.ShowCheckBoxes = false;
            this.treeListStdHullName.OptionsView.ShowVertLines = true;
            this.treeListStdHullName.OptionsView.ShowHorzLines = true;
            this.treeListStdHullName.OptionsView.ShowColumns = false;
            this.treeListStdHullName.OptionsView.ShowRoot = true;
            this.treeListStdHullName.OptionsBehavior.Editable = false;
            this.treeListStdHullName.OptionsBehavior.DragNodes = true;
            this.treeListStdHullName.OptionsSelection.MultiSelect = false;

            treeListStdHullName.DataSource = StdHullList;
            treeListStdHullName.Nodes.Clear();
            treeListStdHullName.RefreshDataSource();
        }

        public void AddtreelistNode()
        {
            int i = 0;
            List<StdHullBasicInformationCls> StdHullBisList = StdHullShellDAL.GetAllStdHullShell();

            foreach (var val in StdHullBisList)
            {
                StdHullList.Add(new StdHull
                {
                    ID=i,
                    StdHullName=val.PlateModel
                    //IsChecked=false
                });
                i++;
            }
        }

        private void creatMainLayerNode(string layerName, bool check)
        {
            //this.treeListColumnStdHull.BeginUnboundLoad();
            //this.treeListLayerControl.AppendNode(new object[] { layerName, check }, -1);
            //this.treeListLayerControl.EndUnboundLoad();
        }

        //初始化下拉框
        public bool init_cmbBox(ObjectEnum ObjectE)
        {
            try
            {
                //初始化人员
                if (ObjectE == ObjectEnum.Admin)
                {
                    this.cbxWorker.Items.Clear();
                    List<AdminsCls> adclsList = AdminsDAL.GetAllAdminsCls();

                    foreach (var val in adclsList)
                    {
                        this.cbxWorker.Items.Add(val.UserName);
                    }
                }
                else if(ObjectE == ObjectEnum.DetectEquipment) //检测设备
                {
                    this.cbxMeasureDevice.Items.Clear();
                    List<DetectEquipmentCls> adclsList = DetectEquipmentDAL.GetAllDetectEquipments();

                    foreach (var val in adclsList)
                    {
                        this.cbxMeasureDevice.Items.Add(val.MeasureDeviceName);
                    }
                }
                else if (ObjectE == ObjectEnum.ProcessEquipment)//加工设备
                {
                    this.cbxProcessEquipment.Items.Clear();
                    List<ProcessEquipmentCls> adclsList = ProcessEquipmentDAL.GetAll();

                    foreach (var val in adclsList)
                    {
                        this.cbxProcessEquipment.Items.Add(val.ProcessEquipmentName);
                    }

                }
                else
                {
                    //初始化软件
                    this.cbxSoftwareInfo.Items.Clear();
                    List<SoftWareCls> adclsList = SoftwareDAL.GetAllSoftware();

                    foreach (var val in adclsList)
                    {
                        this.cbxSoftwareInfo.Items.Add(val.SoftWareName);
                    }

                }
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return true;
        }

        private void btn_ImportScanPoints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_ImportModelFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_ImportInteropFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }

    public class StdHull
    {
        public StdHull()
        {
        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _StdHullName;
        public string StdHullName
        {
            get { return _StdHullName; }
            set { _StdHullName = value; }
        }

        //private bool _IsChecked;
        //public bool IsChecked
        //{
        //    get { return _IsChecked; }
        //    set { _IsChecked = value; }
        //}


    }



}
