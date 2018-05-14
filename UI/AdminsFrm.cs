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
    public partial class AdminsFrm : TemplateFrm
    {
        public AdminsFrm()
        {
            InitializeComponent();
            layoutControlGroup1.Enabled = false;

            //cmbObjectList.Items.Add("123");
            init_cmbbox();
        }

        public void init_cmbbox()
        {
            cmbObjectList.Items.Clear();
            var val = AdminsDAL.GetAllAdmins().ToList();
            for (int i = 0; i < val.Count; i++)
            {
                cmbObjectList.Items.Add(val[i].UserName);
            }
        }

        private void layoutControl1_Click(object sender, EventArgs e)
        {
        }

        public override bool AddData()
        {
            try
            {
                base.AddData();

                Admins var = new Admins();

                layoutControlGroup1.Enabled = true;

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
                    AdminsCls val = new AdminsCls();
                    val.UserName = this.textEdit1.Text.ToString();
                    val.PassWord = this.textEdit2.Text.ToString();
                    val.Role = this.textEdit3.Text.ToString();

                    int re = AdminsDAL.AddAdmin(val);

                    AdminBindingSource.DataSource = val;
                    gridControl1.DataSource = AdminBindingSource;

                    // AdminBindingSource.DataSource=;
                    textEdit1.Text = "";
                    textEdit2.Text = "";
                    textEdit3.Text = "";

                    //this.layoutControl1.Enabled = false;
                    this.layoutControlGroup1.Enabled = false;

                    if (re > 0)
                    {
                        MessageBox.Show("新用户添加成功！");

                        return true;
                    }
                    else
                        return false;
                }
                else
                    if (AddorModify == AddOrModifyEnum.Modify)
                    {
                        adcModify.UserName = textEdit1.Text.ToString();
                        adcModify.PassWord = textEdit2.Text.ToString();
                        adcModify.Role = textEdit3.Text.ToString();

                        int re = AdminsDAL.ModifyAdmins(adcModify);

                        this.layoutControlGroup1.Enabled = false;

                        AdminBindingSource.DataSource = adcModify;
                        gridControl1.DataSource = AdminBindingSource;

                        if (re > 0)
                        {
                            MessageBox.Show("修改成功！");

                            return true;
                        }
                        else
                            return false;
                    }
                    else
                    {
                        return false;
                    }
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

                AdminsCls val = AdminsDAL.QueryAdmin(UserName);

                AdminBindingSource.DataSource = val;

                gridControl1.DataSource = AdminBindingSource;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
            //return base.RefreshData();
        }

        public override bool QueryAll()
        {
            try
            {
                List<AdminsCls> adcList = AdminsDAL.GetAllAdminsCls();

                AdminBindingSource.DataSource = adcList;

                gridControl1.DataSource = AdminBindingSource;
                return true;
            }
            catch (System.Exception ex)
            {
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
                    int[] rows = gridView1.GetSelectedRows();

                    for (int i = 0; i < rows.Length; i++)
                    {
                        AdminsCls val = (AdminsCls)gridView1.GetRow(rows[i]);
                        AdminsDAL.DeleteAdminsById(val.Id);
                    }
                }

                QueryAll();

                init_cmbbox();

                return true;
            }

            catch (System.Exception ex)
            {
                return false;
            }
        }

        public AdminsCls adcModify = new AdminsCls() ;

        public override bool SelectRecord()
        {
            try
            {
                int[] rows = gridView1.GetSelectedRows();
                adcModify = (AdminsCls)gridView1.GetRow(rows[0]);
                textEdit1.Text = adcModify.UserName;
                textEdit2.Text = adcModify.PassWord;
                textEdit3.Text = adcModify.Role;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

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
    }
}
