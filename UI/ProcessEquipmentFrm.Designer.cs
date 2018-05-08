namespace HullShellTest.UI
{
    partial class ProcessEquipmentFrm
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
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDownCount = new DevExpress.XtraEditors.TextEdit();
            this.txtUpCount = new DevExpress.XtraEditors.TextEdit();
            this.txtDriveMode = new DevExpress.XtraEditors.TextEdit();
            this.txtPressureSize = new DevExpress.XtraEditors.TextEdit();
            this.textEquipmentName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ProcessEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDriveMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPressureSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEquipmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessEquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("4f6c7838-121f-4126-b6a7-307448ac809f");
            this.dockPanel1.Location = new System.Drawing.Point(0, 151);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(227, 200);
            this.dockPanel1.Size = new System.Drawing.Size(227, 230);
            this.dockPanel1.Text = "详情";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(219, 203);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtDownCount);
            this.layoutControl1.Controls.Add(this.txtUpCount);
            this.layoutControl1.Controls.Add(this.txtDriveMode);
            this.layoutControl1.Controls.Add(this.txtPressureSize);
            this.layoutControl1.Controls.Add(this.textEquipmentName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(219, 203);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDownCount
            // 
            this.txtDownCount.Location = new System.Drawing.Point(87, 112);
            this.txtDownCount.Name = "txtDownCount";
            this.txtDownCount.Size = new System.Drawing.Size(120, 21);
            this.txtDownCount.StyleController = this.layoutControl1;
            this.txtDownCount.TabIndex = 8;
            // 
            // txtUpCount
            // 
            this.txtUpCount.Location = new System.Drawing.Point(87, 87);
            this.txtUpCount.Name = "txtUpCount";
            this.txtUpCount.Size = new System.Drawing.Size(120, 21);
            this.txtUpCount.StyleController = this.layoutControl1;
            this.txtUpCount.TabIndex = 7;
            // 
            // txtDriveMode
            // 
            this.txtDriveMode.Location = new System.Drawing.Point(87, 62);
            this.txtDriveMode.Name = "txtDriveMode";
            this.txtDriveMode.Size = new System.Drawing.Size(120, 21);
            this.txtDriveMode.StyleController = this.layoutControl1;
            this.txtDriveMode.TabIndex = 6;
            // 
            // txtPressureSize
            // 
            this.txtPressureSize.Location = new System.Drawing.Point(87, 37);
            this.txtPressureSize.Name = "txtPressureSize";
            this.txtPressureSize.Size = new System.Drawing.Size(120, 21);
            this.txtPressureSize.StyleController = this.layoutControl1;
            this.txtPressureSize.TabIndex = 5;
            // 
            // textEquipmentName
            // 
            this.textEquipmentName.Location = new System.Drawing.Point(87, 12);
            this.textEquipmentName.Name = "textEquipmentName";
            this.textEquipmentName.Size = new System.Drawing.Size(120, 21);
            this.textEquipmentName.StyleController = this.layoutControl1;
            this.textEquipmentName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(219, 203);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEquipmentName;
            this.layoutControlItem1.CustomizationFormText = "设备名称";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(199, 25);
            this.layoutControlItem1.Text = "设备名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPressureSize;
            this.layoutControlItem2.CustomizationFormText = "压头尺寸";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(199, 25);
            this.layoutControlItem2.Text = "压头尺寸";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDriveMode;
            this.layoutControlItem3.CustomizationFormText = "驱动方式";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(199, 25);
            this.layoutControlItem3.Text = "驱动方式";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtUpCount;
            this.layoutControlItem4.CustomizationFormText = "上模压头数目";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 75);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(199, 25);
            this.layoutControlItem4.Text = "上模压头数目";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDownCount;
            this.layoutControlItem5.CustomizationFormText = "下模压头数目";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(199, 83);
            this.layoutControlItem5.Text = "下模压头数目";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 14);
            // 
            // ProcessEquipmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 381);
            this.Controls.Add(this.dockPanel1);
            this.Name = "ProcessEquipmentFrm";
            this.Text = "加工设备信息管理";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDownCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDriveMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPressureSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEquipmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessEquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtUpCount;
        private DevExpress.XtraEditors.TextEdit txtDriveMode;
        private DevExpress.XtraEditors.TextEdit txtPressureSize;
        private DevExpress.XtraEditors.TextEdit textEquipmentName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource ProcessEquipmentBindingSource;
        private DevExpress.XtraEditors.TextEdit txtDownCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}