using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HullShellTest.UI
{

    public enum AddOrModifyEnum
    {
        Add = 1,
        Modify
    }

    public partial class TemplateFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public AddOrModifyEnum AddorModify;

        public TemplateFrm()
        {
            InitializeComponent();
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddorModify = AddOrModifyEnum.Add;
            AddData();
        }

        public virtual bool AddData()
        {

            return true;
        }

        private void btn_Modify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddorModify = AddOrModifyEnum.Modify;
            ModifyData();
        }
        public virtual bool ModifyData()
        {
            return true;
        }


        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveDataA();
        }

        public virtual bool SaveDataA()
        {
            return true;
        }

        private void ItemObjectList_EditValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        public virtual bool RefreshData()
        {
            return true;
        }

        private void btn_All_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QueryAll();
        }

        public virtual bool QueryAll()
        {
            return true;

        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteData();
        }

        public virtual bool DeleteData()
        {
            return true;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //SelectRecord();
        }

        public virtual bool SelectRecord()
        {
            return true;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectRecord();
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            SelectRecord();
        }

    }
}
