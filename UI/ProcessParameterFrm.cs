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
using HullShellTest.Utils;

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

            treeListStdHullName.Nodes.Clear();

            init_TreeList();
            AddtreelistNode();

            this.layoutControlGroup1.Enabled = false;
            this.layoutControlGroup2.Enabled = false;

            this.treeListStdHullName.FocusedNode = null;
            ModelParameterDAL.QueryModelParameter();

            unable_Control();

        }

         public string local_stdhullname=null;

         public bool unable_Control()
         {
             base.btn_All.Enabled = false;
             base.ItemObjectList.Enabled = false;
             base.barStaticItem1.Enabled = false;

             return true;
         }

        public  override bool  AddData()
        {
            this.layoutControlGroup1.Enabled = true;
            this.layoutControlGroup2.Enabled = true;

 	        return base.AddData();
        }

        public override bool SaveDataA()
        {
            try
            {
                if (AddorModify == AddOrModifyEnum.Add)
                {
                    ModelParamterBasicCls mpcls = new ModelParamterBasicCls();

                    //数据验证
                    bool isHave = StdHullShellDAL.IsContainTheStdHull(local_stdhullname);

                    if (!isHave)
                    {
                        MessageBox.Show("不存在此钢板，请重新选择！");
                        return false;
                    }

                    mpcls.ProcessNumbers = Convert.ToInt32(this.txtProcessTime.Text.ToString());
                    mpcls.EnvTemperation = Convert.ToDouble(this.txtTemperature.Text.ToString());
                    mpcls.RecordTime = DateTime.Now;
                    mpcls.Coefficient = Convert.ToDouble(this.txtCofficient.Text.ToString());
                    mpcls.ResilienceValue = Convert.ToDouble(this.textResValue.Text.ToString());
                    mpcls.StdHullName = this.local_stdhullname;

                    mpcls.SoftwareName = this.cbxSoftwareInfo.Text.ToString();
                    mpcls.DetectEquipmentName = this.cbxMeasureDevice.Text.ToString();
                    mpcls.ProcessEquipmentName = this.cbxProcessEquipment.Text.ToString();
                    mpcls.UserName = this.cbxWorker.Text.ToString();

                    int re=ModelParameterDAL.AddModelParameter(mpcls);

                    //macls = new MaterialCls();

                    //macls.MaterialName = this.txtMaterialName.Text.ToString();
                    //macls.ElasticModulus = Convert.ToDouble(this.txtElasticModulus.Text.ToString());
                    //macls.TensileStrength = Convert.ToDouble(this.txtTensileStrength.Text.ToString());
                    //macls.YieldSrength = Convert.ToDouble(this.txtYieldSrength.Text.ToString());
                    //macls.UltimateElongation = Convert.ToDouble(this.txtUltimateElongation.Text.ToString());
                    //macls.ReductionOfArea = Convert.ToDouble(this.txtReductionOfArea.Text.ToString());
                    //macls.HardenablityValue = Convert.ToDouble(this.txtHardenablityValue.Text.ToString());
                    //macls.StrainOfWidthAndThickness = Convert.ToDouble(this.txtStrainOfWidthAndThickness.Text.ToString());

                    //int re = MaterialDAL.AddMaterial(macls);

                    if (re> 0)
                    {

                        ModelParameterBindingSource.DataSource = mpcls;
                        this.gridControl1.DataSource = ModelParameterBindingSource;

                        this.txtProcessTime.Text = "";
                        this.txtTemperature.Text = "";
                        this.txtCofficient.Text = "";
                        this.textResValue.Text = "";
                        this.cbxSoftwareInfo.Text = "";
                        this.cbxMeasureDevice.Text = "";
                        this.cbxWorker.Text = "";
                        this.cbxProcessEquipment.Text = "";


                        AddtreelistNode();

                        #region
                        //MaterialBindingSource.DataSource = macls;
                        //this.gridControl1.DataSource = MaterialBindingSource;

                        //this.layoutControlGroup1.Enabled = false;

                        //this.txtMaterialName.Text = "";
                        //this.txtElasticModulus.Text = "";
                        //this.txtTensileStrength.Text = "";
                        //this.txtYieldSrength.Text = "";
                        //this.txtUltimateElongation.Text = "";
                        //this.txtReductionOfArea.Text = "";
                        //this.txtHardenablityValue.Text = "";
                        //this.txtStrainOfWidthAndThickness.Text = "";

                        //init_cmbBox();
                        #endregion

                        MessageBox.Show("加工参数增加成功！");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("加工参数增加失败！");

                        return false;
                    }
                }
                else
                    if (AddorModify == AddOrModifyEnum.Modify)
                    {


                        //macls.MaterialName = this.txtMaterialName.Text.ToString();
                        //macls.ElasticModulus = Convert.ToDouble(this.txtElasticModulus.Text.ToString());
                        //macls.TensileStrength = Convert.ToDouble(this.txtTensileStrength.Text.ToString());
                        //macls.YieldSrength = Convert.ToDouble(this.txtYieldSrength.Text.ToString());
                        //macls.UltimateElongation = Convert.ToDouble(this.txtUltimateElongation.Text.ToString());
                        //macls.ReductionOfArea = Convert.ToDouble(this.txtReductionOfArea.Text.ToString());
                        //macls.HardenablityValue = Convert.ToDouble(this.txtHardenablityValue.Text.ToString());
                        //macls.StrainOfWidthAndThickness = Convert.ToDouble(this.txtStrainOfWidthAndThickness.Text.ToString());

                        //MaterialDAL.ModifyMaterialByid(macls);

                        //this.layoutControlGroup1.Enabled = false;

                        //init_cmbBox();


                        return true;
                    }
                    else
                    {
                        MessageBox.Show("加工参数添加/修改失败！");
                        return false;
                    }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("加工参数添加失败：{0}！", ex.Message.ToString());
                return false;
            }
        }


        public override bool ModifyData()
        {
            try
            {
                TreeListNode nd = this.treeListStdHullName.Selection[0];

                if (nd == null)
                {
                    MessageBox.Show("请选择一个节点！");
                    return false;
                }

                else if(nd.HasChildren)
                {
                    MessageBox.Show("请选择一个子节点！");
                    return false;
                }

                ModelParamterBasicCls mpbs=(ModelParamterBasicCls)this.gridControl1.DataSource;

                if (mpbs == null)
                {
                    MessageBox.Show("请选择一个记录！");
                    return false;
                }


                this.txtProcessTime.Text = Convert.ToString(mpbs.ProcessNumbers);
                this.txtProcessTime.Text = Convert.ToString(mpbs.ProcessNumbers);
                this.txtProcessTime.Text = Convert.ToString(mpbs.ProcessNumbers);
                this.txtProcessTime.Text = Convert.ToString(mpbs.ProcessNumbers);
                this.txtProcessTime.Text = Convert.ToString(mpbs.ProcessNumbers);


                this.layoutControlGroup1.Enabled = true;
                this.layoutControlGroup2.Enabled = true;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

         public List<StdHullTreeList> StdHullList = new List<StdHullTreeList>();

        private void init_TreeList()
        {
            //初始化理论曲板列表
            DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnOrder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            treeListColumnOrder.Caption = "序号";
            treeListColumnOrder.FieldName = "OrderID";
            treeListColumnOrder.MinWidth = 25;
            treeListColumnOrder.Name = "treeListColumnOrder";
            treeListColumnOrder.Visible = true;
            treeListColumnOrder.VisibleIndex = 0;
            treeListColumnOrder.Width = 25;

            DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnStdHull = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            treeListColumnStdHull.Caption = "理论曲板名称";
            //treeListColumnStdHull.ColumnEdit = this.repositoryItemCheckEdit1;
            treeListColumnStdHull.FieldName = "StdHullName";
            treeListColumnStdHull.Name = "treeListColumnStdHull";
            treeListColumnStdHull.Visible = true;
            treeListColumnStdHull.VisibleIndex = 1;
            treeListColumnOrder.MinWidth = 38;
            treeListColumnOrder.Width = 111;

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
            this.treeListStdHullName.ExpandAll();
        }

        public void AddtreelistNode()
        {

            this.treeListStdHullName.Nodes.Clear();

            int i = 0;

            List<StdHullBasicInformationCls> StdHullBisList = StdHullShellDAL.GetAllStdHullShell();

            foreach (var val in StdHullBisList)
            {
                #region
                //StdHullList.Add(new StdHullTreeList
                //{
                //    OrderID=i,
                //    StdHullName=val.PlateModel,
                //    ID=1
                //    //ParentID=1
                //});

                //i++;
                #endregion

                TreeListNode nd = treeListStdHullName.AppendNode(new Object[]{val.Id.ToString(),val.PlateModel.ToString()},null);

                List<string> childName = ModelParameterDAL.QueryModelParameter(val.PlateModel.ToString());

                if (childName.Count == 0)
                {
                    continue;
                }
                else
                {
                    for(int j=0;j<childName.Count();j++)
                    {

                        treeListStdHullName.AppendNode(new Object[] { j.ToString(), childName[j].ToString() }, nd);
                    }
                }


            }

            //treeListStdHullName.DataSource = StdHullList;


            //treeListStdHullName.RefreshDataSource();

            treeListStdHullName.ExpandAll();
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

        public ScanPointsCls sPtCls = new ScanPointsCls();
        private void btn_ImportScanPoints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                sPtCls = ReadFile.ReadScanPts(fName);
            }


            ScanPointsBindingSource.DataSource = sPtCls.SPList;
            ScanPointsGridControl.DataSource = ScanPointsBindingSource;

            this.dpScanPoints.Show();
        }

        private void btn_ImportModelFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_ImportInteropFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void treeListStdHullName_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {

            if(this.treeListStdHullName.FocusedNode==null)
            {
                return;
            }
            this.local_stdhullname = treeListStdHullName.Selection[0].GetDisplayText(1).ToString();



        }

        //保存选择的点云文件
        public string StdHullName;
        public string ProcessNumber;

        public ModelParamterBasicCls mpcls = new ModelParamterBasicCls();

        private void btn_View_Click(object sender, EventArgs e)
        {
            TreeListNode nd = this.treeListStdHullName.Selection[0];

            if (nd == null)
            {
                MessageBox.Show("请选择一个数据节点！");
                return;
            }

            if(nd.HasChildren)
            {
                MessageBox.Show("请选择一个子节点！");
                return;
            }

           StdHullName = nd.ParentNode.GetDisplayText(1).ToString();
           ProcessNumber = nd.GetDisplayText(1).ToString().Split(':')[1];
           
           mpcls = ModelParameterDAL.QueryModelParameterByNameAndNo(StdHullName, Convert.ToInt32(ProcessNumber));
           ModelParameterBindingSource.DataSource = ModelParameterDAL.QueryModelParameterByNameAndNo(StdHullName, Convert.ToInt32(ProcessNumber));
           gridControl1.DataSource = ModelParameterBindingSource;
             
           DefectsListCls dlc = ModelParameterDAL.QueryModelParameterDefects(StdHullName,Convert.ToInt32(ProcessNumber));
          
            if (dlc == null)
           {
               MessageBox.Show("不存在缺陷列表！");
               return;
           }

           this.textDefectName.Text = dlc.DefectName;
           this.textReason .Text= dlc.DefectReason;
           this.textSolution.Text = dlc.Slution;

           this.dockPanel1.Show();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddDefects_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            TreeListNode nd = this.treeListStdHullName.Selection[0];

            if (nd == null)
            {
                MessageBox.Show("请选择一个节点！");
            }

            if (nd.HasChildren)
            {
                MessageBox.Show("请选择一个子节点！");
                return;
            }


            DefectsListCls defcls = new DefectsListCls
            {
                DefectName=this.textDefectName.Text,
                DefectReason=this.textReason.Text,
                Slution=this.textSolution.Text
            };


            string StdHullName = nd.ParentNode.GetDisplayText(1).ToString();
            string ProcessNumber = nd.GetDisplayText(1).ToString().Split(':')[1];

            bool isAdd=ModelParameterDAL.AddDefects(StdHullName,Convert.ToInt32(ProcessNumber),defcls);

            this.layoutControl2.Enabled = false;
            this.layoutControl1.Enabled = false;

            if (isAdd)
            {
                MessageBox.Show("添加成功！");
                return;
            }
            else
            {
                MessageBox.Show("添加失败！");
                return;
            }
                        
        }


    }

    public class StdHullTreeList
    {
        //public StdHullTreeList()
        //{

        //}

        private int _OrderID;
        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

        private string _StdHullName=string.Empty;
        public string StdHullName
        {
            get { return _StdHullName; }
            set { _StdHullName = value; }
        }

        private int m_iID = -1;  //子节点
        public int ID
        {
            get { return m_iID; }
            set { m_iID = value; }
        }

        private int m_iPartentID = -1; //父节点
        public int ParentID
        {
            get { return m_iPartentID; }
            set { m_iPartentID = value; }
        }

    }



}
