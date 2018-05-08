using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HullShellTest.DAL;
using DevExpress.XtraEditors;
using HullShellTest.ModelData;
using HullShellTest.DAL;

namespace HullShellTest.UI
{
    public partial class ProcessEquipmentFrm : TemplateFrm
    {
        public ProcessEquipmentFrm()
        {
            InitializeComponent();
            pecls = new ProcessEquipmentCls();
            pecList = new List<ProcessEquipmentCls>();

            this.layoutControlGroup1.Enabled = false;

            init_cmbBox();
        }

        public ProcessEquipmentCls pecls;
        public List<ProcessEquipmentCls> pecList;

        //下拉框初始化
        public bool init_cmbBox()
        {
            try
            {
                this.cmbObjectList.Items.Clear();
                pecList = new List<ProcessEquipmentCls>();
                pecList = ProcessEquipmentDAL.GetAll();

                foreach (var val in pecList)
                {
                    this.cmbObjectList.Items.Add(val.ProcessEquipmentName);
                }

                return true; ;

            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //查询所有
        public override bool QueryAll()
        {
            try
            {
                pecList = new List<ProcessEquipmentCls>();

                pecList = ProcessEquipmentDAL.GetAll();

                ProcessEquipmentBindingSource.DataSource = pecList;
                this.gridControl1.DataSource = ProcessEquipmentBindingSource;

                return true;
            }
            catch (System.Exception ex)
            {
            	return false;
            }
        }

        //增加
        public override bool AddData()
        {
            try
            {
                this.layoutControlGroup1.Enabled = true;
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //保存
        public override bool SaveDataA()
        {
            try
            {
                if (AddorModify == AddOrModifyEnum.Add)
                {
                    pecls = new ProcessEquipmentCls();

                    pecls.ProcessEquipmentName = this.textEquipmentName.Text.ToString();
                    pecls.DirverMode = this.txtDriveMode.Text.ToString();
                    pecls.PressureHeadLength = Convert.ToInt32(this.txtPressureSize.Text.ToString());
                    pecls.UpDieHeadNumber = Convert.ToInt32(this.txtUpCount.Text.ToString());
                    pecls.DownDieHeadNumber = Convert.ToInt32(this.txtDownCount.Text.ToString());

                    int re = ProcessEquipmentDAL.AddProcessEquipment(pecls);

                    if (re > 0)
                    {
                        ProcessEquipmentBindingSource.DataSource = pecls;
                        this.gridControl1.DataSource = ProcessEquipmentBindingSource;

                        this.layoutControlGroup1.Enabled = false;

                        this.textEquipmentName.Text = "";
                        this.txtDriveMode.Text = "";
                        this.txtPressureSize.Text = "";
                        this.txtUpCount.Text = "";
                        this.txtDownCount.Text = "";

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
                    pecls.ProcessEquipmentName = this.textEquipmentName.Text.ToString();
                    pecls.DirverMode = this.txtDriveMode.Text.ToString();
                    pecls.PressureHeadLength = Convert.ToInt32(this.txtPressureSize.Text.ToString());
                    pecls.UpDieHeadNumber = Convert.ToInt32(this.txtUpCount.Text.ToString());
                    pecls.DownDieHeadNumber = Convert.ToInt32(this.txtDownCount.Text.ToString());

                    ProcessEquipmentDAL.ModifyProcessEquipmentById(pecls);

                    this.layoutControlGroup1.Enabled = false;

                    init_cmbBox();


                    return true;
                }
                else
                {
                    MessageBox.Show("加工设备添加/修改失败！");
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("加工设备添加失败：{0}！", ex.Message.ToString());
                return false;
            }
        }

        //删除
        public override bool DeleteData()
        {
            try
            {
                if (XtraMessageBox.Show("是否删除选中的数据？", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    pecls=new ProcessEquipmentCls();

                    int[] rows = gridView1.GetSelectedRows();

                    for (int i = 0; i < rows.Length; i++)
                    {
                        pecls = (ProcessEquipmentCls)gridView1.GetRow(rows[i]);
                        ProcessEquipmentDAL.DeleteProcessEquipmentById(pecls.Id);
                    }
                }

                //QueryAll();

                init_cmbBox();

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }


            //return base.DeleteData();
        }

        public override bool RefreshData()
        {
            try
            {
                string UserName = this.ItemObjectList.EditValue.ToString();

                ProcessEquipmentCls val = ProcessEquipmentDAL.QueryProcessEquipmentByName(UserName);

                ProcessEquipmentBindingSource.DataSource = val;

                gridControl1.DataSource = ProcessEquipmentBindingSource;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //修改
        public override bool ModifyData()
        {
            try
            {
                this.layoutControlGroup1.Enabled = true;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //选择记录
        public override bool SelectRecord()
        {
            try
            {
                pecls = new ProcessEquipmentCls();

                int[] rows = gridView1.GetSelectedRows();
                pecls = (ProcessEquipmentCls)gridView1.GetRow(rows[0]);

                textEquipmentName.Text = pecls.ProcessEquipmentName;
                txtDriveMode.Text = pecls.DirverMode;
                txtPressureSize.Text = pecls.PressureHeadLength.ToString();
                txtDownCount.Text = pecls.DownDieHeadNumber.ToString();
                txtUpCount.Text = pecls.UpDieHeadNumber.ToString();

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

    }
}
