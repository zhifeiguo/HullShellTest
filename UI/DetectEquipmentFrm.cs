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
    public partial class DetectEquipmentFrm : TemplateFrm
    {
        public DetectEquipmentFrm()
        {
            InitializeComponent();

            this.layoutControlGroup1.Enabled = false;

            Init_decBox();

        }

        public DetectEquipmentCls dec;

        //初始化下拉框
        public bool Init_decBox()
        {
            try
            {
                this.cmbObjectList.Items.Clear();

                List<DetectEquipmentCls> deList = DetectEquipmentDAL.GetAllDetectEquipments();
                foreach(var item in deList)
                {
                    this.cmbObjectList.Items.Add(item.MeasureDeviceName);
                }

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
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

                    dec = new DetectEquipmentCls();

                    for (int i = 0; i < rows.Length; i++)
                    {
                        dec = (DetectEquipmentCls)gridView1.GetRow(rows[i]);
                        DetectEquipmentDAL.DeleteDetectEuipmentById(dec.Id);
                    }
                }

                QueryAll();

                Init_decBox();
                dec = new DetectEquipmentCls();
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
                 if (AddorModify==AddOrModifyEnum.Add)
                {
                    dec = new DetectEquipmentCls();
                    dec.MeasureDeviceName = txtEquipmentName.Text.ToString();
                    dec.CameraResolution = txtCameraResolution.Text.ToString();
                    dec.PixelSize = txtPixelLength.Text.ToString();
                    dec.StdPrecision = Convert.ToDouble(txtPrecious.Text.ToString());

                    DetectEquipmentDAL.AddDetectEquipment(dec);

                    txtEquipmentName.Text = "";
                    txtCameraResolution.Text = "";
                    txtPixelLength.Text = "";
                    txtPrecious.Text = "";

                    this.layoutControlGroup1.Enabled = false;

                    DetectEquipmentBindingSource.DataSource = dec;
                    this.gridControl1.DataSource = DetectEquipmentBindingSource;

                    Init_decBox();

                    MessageBox.Show("测量设备添加成功！");

                    dec = new DetectEquipmentCls();

                    return true;

                }
                 else if (AddorModify == AddOrModifyEnum.Modify)
                {
                    dec.MeasureDeviceName = this.txtEquipmentName.Text.ToString();
                    dec.CameraResolution = this.txtCameraResolution.Text.ToString();
                    dec.PixelSize = this.txtPixelLength.Text. ToString();
                    dec.StdPrecision = Convert.ToDouble(this.txtPrecious.Text.ToString());

                    DetectEquipmentDAL.ModifyDetectEquipmentById(dec);

                    this.layoutControlGroup1.Enabled = false;

                    //this.txtPrecious.Text = "";
                    //this.txtCameraResolution.Text = "";
                    //this.txtEquipmentName.Text = "";
                    //this.txtPixelLength.Text = "";

                    MessageBox.Show("修改成功！");

                    dec = new DetectEquipmentCls();

                    return true;
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
                dec=new DetectEquipmentCls();

                string decName = this.ItemObjectList.EditValue.ToString();
                dec=DetectEquipmentDAL.QueryDetectEquipmentByName(decName);

                DetectEquipmentBindingSource.DataSource = dec;

                this.gridControl1.DataSource=DetectEquipmentBindingSource;

                dec = new DetectEquipmentCls();

                return true;
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
                List<DetectEquipmentCls> decList = DetectEquipmentDAL.GetAllDetectEquipments();

                DetectEquipmentBindingSource.DataSource = decList;

                this.gridControl1.DataSource = DetectEquipmentBindingSource;

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

        public override bool SelectRecord()
        {
            try
            {
                dec = new DetectEquipmentCls();
                int[] rows=this.gridView1.GetSelectedRows();
                dec = (DetectEquipmentCls)this.gridView1.GetRow(rows[0]);

                this.txtEquipmentName.Text=dec.MeasureDeviceName;
                this.txtCameraResolution.Text = dec.CameraResolution;
                this.txtPixelLength.Text = dec.PixelSize;
                this.txtPrecious.Text = dec.StdPrecision.ToString();

                //dec = new DetectEquipmentCls();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

    }
}
