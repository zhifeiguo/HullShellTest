namespace HullShellTest.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_SoftWare = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DetectEquipment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ProcessEquipment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Material = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Worker = new DevExpress.XtraBars.BarButtonItem();
            this.btn_StdHull = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ProcessParameter = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_SoftWare,
            this.btn_DetectEquipment,
            this.btn_ProcessEquipment,
            this.btn_Material,
            this.btn_Worker,
            this.btn_StdHull,
            this.btn_ProcessParameter});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1043, 184);
            // 
            // btn_SoftWare
            // 
            this.btn_SoftWare.Caption = "软件";
            this.btn_SoftWare.Id = 1;
            this.btn_SoftWare.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_SoftWare.LargeGlyph")));
            this.btn_SoftWare.Name = "btn_SoftWare";
            this.btn_SoftWare.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SoftWare_ItemClick);
            // 
            // btn_DetectEquipment
            // 
            this.btn_DetectEquipment.Caption = "检测设备";
            this.btn_DetectEquipment.Id = 2;
            this.btn_DetectEquipment.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_DetectEquipment.LargeGlyph")));
            this.btn_DetectEquipment.Name = "btn_DetectEquipment";
            this.btn_DetectEquipment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DetectEquipment_ItemClick);
            // 
            // btn_ProcessEquipment
            // 
            this.btn_ProcessEquipment.Caption = "加工设备";
            this.btn_ProcessEquipment.Id = 3;
            this.btn_ProcessEquipment.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ProcessEquipment.LargeGlyph")));
            this.btn_ProcessEquipment.Name = "btn_ProcessEquipment";
            this.btn_ProcessEquipment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ProcessEquipment_ItemClick);
            // 
            // btn_Material
            // 
            this.btn_Material.Caption = "材料";
            this.btn_Material.Id = 4;
            this.btn_Material.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Material.LargeGlyph")));
            this.btn_Material.Name = "btn_Material";
            this.btn_Material.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Material_ItemClick);
            // 
            // btn_Worker
            // 
            this.btn_Worker.Caption = "作业人员";
            this.btn_Worker.Id = 5;
            this.btn_Worker.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Worker.LargeGlyph")));
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Worker_ItemClick);
            // 
            // btn_StdHull
            // 
            this.btn_StdHull.Caption = "理论曲板";
            this.btn_StdHull.Id = 6;
            this.btn_StdHull.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_StdHull.LargeGlyph")));
            this.btn_StdHull.Name = "btn_StdHull";
            this.btn_StdHull.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_StdHull_ItemClick);
            // 
            // btn_ProcessParameter
            // 
            this.btn_ProcessParameter.Caption = "工艺参数";
            this.btn_ProcessParameter.Id = 7;
            this.btn_ProcessParameter.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ProcessParameter.LargeGlyph")));
            this.btn_ProcessParameter.Name = "btn_ProcessParameter";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "基础数据";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Worker);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_SoftWare);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DetectEquipment);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ProcessEquipment);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Material);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_StdHull);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "数据";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ProcessParameter);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "工艺参数";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "数据管理";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::HullShellTest.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(1043, 715);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "曲板加工工艺数据";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_SoftWare;
        private DevExpress.XtraBars.BarButtonItem btn_DetectEquipment;
        private DevExpress.XtraBars.BarButtonItem btn_ProcessEquipment;
        private DevExpress.XtraBars.BarButtonItem btn_Material;
        private DevExpress.XtraBars.BarButtonItem btn_Worker;
        private DevExpress.XtraBars.BarButtonItem btn_StdHull;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_ProcessParameter;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}