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

namespace HullShellTest.UI
{
    public partial class MaterialFrm : TemplateFrm
    {
        public MaterialFrm()
        {
            InitializeComponent();

            this.layoutControlGroup1.Enabled = false;

            macls = new MaterialCls();
            maList = new List<MaterialCls>();

            init_cmbBox();
        }

        public MaterialCls macls;
        public List<MaterialCls> maList;

        //下拉框初始化
        public bool init_cmbBox()
        {
            try
            {
                this.cmbObjectList.Items.Clear();
                maList = new List<MaterialCls>();
                maList = MaterialDAL.GetAll();

                foreach (var val in maList)
                {
                    this.cmbObjectList.Items.Add(val.MaterialName);
                }

                return true;
                ;
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
                maList = new List<MaterialCls>();

                maList = MaterialDAL.GetAll();

                MaterialBindingSource.DataSource = maList;
                this.gridControl1.DataSource = MaterialBindingSource;

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
                    macls = new MaterialCls();

                    macls.MaterialName = this.txtMaterialName.Text.ToString();
                    macls.ElasticModulus = Convert.ToDouble(this.txtElasticModulus.Text.ToString());
                    macls.TensileStrength = Convert.ToDouble(this.txtTensileStrength.Text.ToString());
                    macls.YieldSrength = Convert.ToDouble(this.txtYieldSrength.Text.ToString());
                    macls.UltimateElongation = Convert.ToDouble(this.txtUltimateElongation.Text.ToString());
                    macls.ReductionOfArea = Convert.ToDouble(this.txtReductionOfArea.Text.ToString());
                    macls.HardenablityValue = Convert.ToDouble(this.txtHardenablityValue.Text.ToString());
                    macls.StrainOfWidthAndThickness = Convert.ToDouble(this.txtStrainOfWidthAndThickness.Text.ToString());

                    int re = MaterialDAL.AddMaterial(macls);

                    if (re > 0)
                    {
                        MaterialBindingSource.DataSource = macls;
                        this.gridControl1.DataSource = MaterialBindingSource;

                        this.layoutControlGroup1.Enabled = false;

                        this.txtMaterialName.Text = "";
                        this.txtElasticModulus.Text = "";
                        this.txtTensileStrength.Text = "";
                        this.txtYieldSrength.Text = "";
                        this.txtUltimateElongation.Text = "";
                        this.txtReductionOfArea.Text = "";
                        this.txtHardenablityValue.Text = "";
                        this.txtStrainOfWidthAndThickness.Text = "";

                        init_cmbBox();

                        MessageBox.Show("材料信息增加成功！");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("材料信息增加失败！");

                        return false;
                    }
                }
                else
                    if (AddorModify == AddOrModifyEnum.Modify)
                    {
                        macls.MaterialName = this.txtMaterialName.Text.ToString();
                        macls.ElasticModulus = Convert.ToDouble(this.txtElasticModulus.Text.ToString());
                        macls.TensileStrength = Convert.ToDouble(this.txtTensileStrength.Text.ToString());
                        macls.YieldSrength = Convert.ToDouble(this.txtYieldSrength.Text.ToString());
                        macls.UltimateElongation = Convert.ToDouble(this.txtUltimateElongation.Text.ToString());
                        macls.ReductionOfArea = Convert.ToDouble(this.txtReductionOfArea.Text.ToString());
                        macls.HardenablityValue = Convert.ToDouble(this.txtHardenablityValue.Text.ToString());
                        macls.StrainOfWidthAndThickness = Convert.ToDouble(this.txtStrainOfWidthAndThickness.Text.ToString());

                        MaterialDAL.ModifyMaterialByid(macls);

                        this.layoutControlGroup1.Enabled = false;

                        init_cmbBox();


                        return true;
                    }
                    else
                    {
                        MessageBox.Show("材料信息添加/修改失败！");
                        return false;
                    }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("材料信息添加失败：{0}！", ex.Message.ToString());
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
                    macls = new MaterialCls();

                    int[] rows = gridView1.GetSelectedRows();

                    for (int i = 0; i < rows.Length; i++)
                    {
                        macls = (MaterialCls)gridView1.GetRow(rows[i]);
                        MaterialDAL.DeleteMaterialById(macls.Id);
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
        }

        public override bool RefreshData()
        {
            try
            {
                string UserName = this.ItemObjectList.EditValue.ToString();

                MaterialCls val = MaterialDAL.QueryMaterialByName(UserName);

                MaterialBindingSource.DataSource = val;

                gridControl1.DataSource = MaterialBindingSource;

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
                macls = new MaterialCls();

                int[] rows = gridView1.GetSelectedRows();
                macls = (MaterialCls)gridView1.GetRow(rows[0]);

                this.txtMaterialName.Text = macls.MaterialName;
                this.txtElasticModulus.Text = macls.ElasticModulus.ToString();
                this.txtTensileStrength.Text = macls.TensileStrength.ToString();
                this.txtYieldSrength.Text = macls.YieldSrength.ToString();
                this.txtReductionOfArea.Text = macls.ReductionOfArea.ToString();
                this.txtUltimateElongation.Text = macls.UltimateElongation.ToString();
                this.txtHardenablityValue.Text = macls.HardenablityValue.ToString();
                this.txtStrainOfWidthAndThickness.Text = macls.StrainOfWidthAndThickness.ToString();
                //macls.TensileStrength = Convert.ToDouble(this.txtTensileStrength.Text.ToString());
                //macls.YieldSrength = Convert.ToDouble(this.txtYieldSrength.Text.ToString());
                //macls.UltimateElongation = Convert.ToDouble(this.txtUltimateElongation.Text.ToString());
                //macls.ReductionOfArea = Convert.ToDouble(this.txtReductionOfArea.Text.ToString());
                //macls.HardenablityValue = Convert.ToDouble(this.txtHardenablityValue.Text.ToString());
                //macls.StrainOfWidthAndThickness = Convert.ToDouble(this.txtStrainOfWidthAndThickness.Text.ToString());

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
    }
}
