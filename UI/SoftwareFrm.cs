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
using DevExpress.XtraEditors;

namespace HullShellTest.UI
{
    public partial class SoftwareFrm : TemplateFrm
    {
        public SoftWareCls sfwcls;
        public List<SoftWareCls> sfwList;

        public SoftwareFrm()
        {
            InitializeComponent();
            sfwcls = new SoftWareCls();
            sfwList = new List<SoftWareCls>();

            this.layoutControlGroup1.Enabled = false;

            init_cmbBox();
        }

        //下拉框初始化
        public bool init_cmbBox()
        {
            try
            {
                this.cmbObjectList.Items.Clear();
                sfwList = new List<SoftWareCls>();
                sfwList = SoftwareDAL.GetAllSoftware();

                foreach (var val in sfwList)
                {
                    this.cmbObjectList.Items.Add(val.SoftWareName);
                }

                return false;
            }
            catch (System.Exception ex)
            {
                return true;
            }
        }

        //添加
        public override bool AddData()
        {
            try
            {
                this.layoutControlGroup1.Enabled = true;

                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("软件信息增加失败:{0}!", ex.Message.ToString());

                return false;
            }

            //return base.AddData();
        }

        public override bool SaveDataA()
        {
            try
            {
                if (AddorModify == AddOrModifyEnum.Add)
                {
                    sfwcls = new SoftWareCls();

                    sfwcls.SoftWareName = this.textSoftwareName.Text.ToString();
                    sfwcls.RegisterAlgorithm = this.textRegistrationMethod.Text.ToString();
                    sfwcls.DiffComputer = this.textDiffComputer.Text.ToString();
                    sfwcls.SurfaceReconstruction = this.txtSurfaceReconstruct.Text.ToString();

                    int re = SoftwareDAL.AddSoftware(sfwcls);

                    if (re > 0)
                    {
                        SoftwarebindingSource.DataSource = sfwcls;
                        this.gridControl1.DataSource = SoftwarebindingSource;

                        this.layoutControlGroup1.Enabled = false;

                        this.textDiffComputer.Text = "";
                        this.textRegistrationMethod.Text = "";
                        this.textSoftwareName.Text = "";
                        this.txtSurfaceReconstruct.Text = "";

                        init_cmbBox();

                        MessageBox.Show("软件信息增加成功！");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("软件信息增加失败！");

                        return false;
                    }
                }
                else
                    if (AddorModify == AddOrModifyEnum.Modify)
                    {
                        sfwcls.SoftWareName = textSoftwareName.Text.ToString();
                        sfwcls.RegisterAlgorithm = textRegistrationMethod.Text.ToString();
                        sfwcls.DiffComputer = textDiffComputer.Text.ToString();
                        sfwcls.SurfaceReconstruction = txtSurfaceReconstruct.Text.ToString();

                        SoftwareDAL.ModifySoftWareById(sfwcls);

                        this.layoutControlGroup1.Enabled = false;

                        init_cmbBox();


                        return true;
                    }
                    else
                    {
                        MessageBox.Show("软件信息添加/修改失败！");
                        return false;
                    }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("软件信息添加失败：{0}！", ex.Message.ToString());
                return false;
            }
        }

        public override bool QueryAll()
        {
            try
            {
                sfwList = new List<SoftWareCls>();
                sfwList = SoftwareDAL.GetAllSoftware();
                SoftwarebindingSource.DataSource = sfwList;
                this.gridControl1.DataSource = SoftwarebindingSource;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
            //return base.QueryAll();
        }

        public override bool DeleteData()
        {
            try
            {
                if (XtraMessageBox.Show("是否删除选中的数据？", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int[] rows = gridView1.GetSelectedRows();

                    for (int i = 0; i < rows.Length; i++)
                    {
                        SoftWareCls val = (SoftWareCls)gridView1.GetRow(rows[i]);
                        SoftwareDAL.DeleteSoftwareById(val.Id);
                    }
                }

                QueryAll();

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

                SoftWareCls val = SoftwareDAL.QuerySoftWareByName(UserName);

                SoftwarebindingSource.DataSource = val;

                gridControl1.DataSource = SoftwarebindingSource;

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
                sfwcls = new SoftWareCls();

                int[] rows = gridView1.GetSelectedRows();
                sfwcls = (SoftWareCls)gridView1.GetRow(rows[0]);

                textSoftwareName.Text = sfwcls.SoftWareName;
                textRegistrationMethod.Text = sfwcls.RegisterAlgorithm;
                textDiffComputer.Text = sfwcls.DiffComputer;
                txtSurfaceReconstruct.Text = sfwcls.SurfaceReconstruction;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //修改



    }
}
