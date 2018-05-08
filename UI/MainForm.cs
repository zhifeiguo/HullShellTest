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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_SoftWare_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SoftwareFrm sfrm = new SoftwareFrm();
            sfrm.MdiParent = this;
            sfrm.Show();
        }

        private void btn_Worker_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdminsFrm admFrm = new AdminsFrm();
            admFrm.MdiParent = this;
            admFrm.Show();
        }

        private void btn_DetectEquipment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DetectEquipmentFrm defrm = new DetectEquipmentFrm();
            defrm.MdiParent = this;
            defrm.Show();
        }

        private void btn_ProcessEquipment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessEquipmentFrm pefrm = new ProcessEquipmentFrm();
            pefrm.MdiParent = this;
            pefrm.Show();
        }

        private void btn_Material_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaterialFrm mafrm = new MaterialFrm();
            mafrm.MdiParent = this;
            mafrm.Show();
        }

        private void btn_StdHull_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StdHullFrm shfrm = new StdHullFrm();
            shfrm.MdiParent = this;
            shfrm.Show();
        }
    }
}
