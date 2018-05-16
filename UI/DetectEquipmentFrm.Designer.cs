namespace HullShellTest.UI
{
    partial class DetectEquipmentFrm
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtPrecious = new DevExpress.XtraEditors.TextEdit();
            this.txtPixelLength = new DevExpress.XtraEditors.TextEdit();
            this.txtCameraResolution = new DevExpress.XtraEditors.TextEdit();
            this.txtEquipmentName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CameraResolution = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DetectEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecious.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCameraResolution.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectEquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Size = new System.Drawing.Size(1127, 184);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.dockPanel1_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel.ID = new System.Guid("13fc3033-1726-49c8-87ec-205ffdda2eb5");
            this.dockPanel.Location = new System.Drawing.Point(0, 184);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.OriginalSize = new System.Drawing.Size(219, 200);
            this.dockPanel.Size = new System.Drawing.Size(219, 531);
            this.dockPanel.Text = "详情";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 30);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(211, 497);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtPrecious);
            this.layoutControl1.Controls.Add(this.txtPixelLength);
            this.layoutControl1.Controls.Add(this.txtCameraResolution);
            this.layoutControl1.Controls.Add(this.txtEquipmentName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(549, 123, 384, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(211, 497);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtPrecious
            // 
            this.txtPrecious.Location = new System.Drawing.Point(123, 108);
            this.txtPrecious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecious.Name = "txtPrecious";
            this.txtPrecious.Size = new System.Drawing.Size(76, 28);
            this.txtPrecious.StyleController = this.layoutControl1;
            this.txtPrecious.TabIndex = 7;
            // 
            // txtPixelLength
            // 
            this.txtPixelLength.Location = new System.Drawing.Point(123, 76);
            this.txtPixelLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPixelLength.Name = "txtPixelLength";
            this.txtPixelLength.Size = new System.Drawing.Size(76, 28);
            this.txtPixelLength.StyleController = this.layoutControl1;
            this.txtPixelLength.TabIndex = 6;
            // 
            // txtCameraResolution
            // 
            this.txtCameraResolution.Location = new System.Drawing.Point(123, 44);
            this.txtCameraResolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCameraResolution.Name = "txtCameraResolution";
            this.txtCameraResolution.Size = new System.Drawing.Size(76, 28);
            this.txtCameraResolution.StyleController = this.layoutControl1;
            this.txtCameraResolution.TabIndex = 5;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(123, 12);
            this.txtEquipmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(76, 28);
            this.txtEquipmentName.StyleController = this.layoutControl1;
            this.txtEquipmentName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CameraResolution,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(211, 497);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // CameraResolution
            // 
            this.CameraResolution.Control = this.txtCameraResolution;
            this.CameraResolution.CustomizationFormText = "layoutControlItem2";
            this.CameraResolution.Location = new System.Drawing.Point(0, 32);
            this.CameraResolution.Name = "CameraResolution";
            this.CameraResolution.Size = new System.Drawing.Size(191, 32);
            this.CameraResolution.Text = "相机分辨率";
            this.CameraResolution.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPixelLength;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(191, 32);
            this.layoutControlItem3.Text = "像素尺寸";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPrecious;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(191, 381);
            this.layoutControlItem4.Text = "标定精度";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtEquipmentName;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(191, 32);
            this.layoutControlItem1.Text = "检测设备名字";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 22);
            // 
            // DetectEquipmentBindingSource
            // 
            this.DetectEquipmentBindingSource.DataSource = typeof(HullShellTest.ModelData.DetectEquipmentCls);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DetectEquipmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 715);
            this.Controls.Add(this.dockPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "DetectEquipmentFrm";
            this.Text = "检测设备信息管理";
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.dockPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecious.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCameraResolution.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectEquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource DetectEquipmentBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.TextEdit txtEquipmentName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtPrecious;
        private DevExpress.XtraEditors.TextEdit txtPixelLength;
        private DevExpress.XtraEditors.TextEdit txtCameraResolution;
        private DevExpress.XtraLayout.LayoutControlItem CameraResolution;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}