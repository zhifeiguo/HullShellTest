namespace HullShellTest.UI
{
    partial class SoftwareFrm
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
            this.SoftwarebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtSurfaceReconstruct = new DevExpress.XtraEditors.TextEdit();
            this.textDiffComputer = new DevExpress.XtraEditors.TextEdit();
            this.textRegistrationMethod = new DevExpress.XtraEditors.TextEdit();
            this.textSoftwareName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwarebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurfaceReconstruct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDiffComputer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegistrationMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoftwareName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // SoftwarebindingSource
            // 
            this.SoftwarebindingSource.DataSource = typeof(HullShellTest.ModelData.SoftWareCls);
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
            this.dockPanel1.ID = new System.Guid("7fbf7fb7-7e59-4948-b073-cd53e26dd501");
            this.dockPanel1.Location = new System.Drawing.Point(0, 151);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(221, 200);
            this.dockPanel1.Size = new System.Drawing.Size(221, 230);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(213, 203);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtSurfaceReconstruct);
            this.layoutControl1.Controls.Add(this.textDiffComputer);
            this.layoutControl1.Controls.Add(this.textRegistrationMethod);
            this.layoutControl1.Controls.Add(this.textSoftwareName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(213, 203);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtSurfaceReconstruct
            // 
            this.txtSurfaceReconstruct.Location = new System.Drawing.Point(63, 87);
            this.txtSurfaceReconstruct.Name = "txtSurfaceReconstruct";
            this.txtSurfaceReconstruct.Size = new System.Drawing.Size(138, 21);
            this.txtSurfaceReconstruct.StyleController = this.layoutControl1;
            this.txtSurfaceReconstruct.TabIndex = 7;
            // 
            // textDiffComputer
            // 
            this.textDiffComputer.Location = new System.Drawing.Point(63, 62);
            this.textDiffComputer.Name = "textDiffComputer";
            this.textDiffComputer.Size = new System.Drawing.Size(138, 21);
            this.textDiffComputer.StyleController = this.layoutControl1;
            this.textDiffComputer.TabIndex = 6;
            // 
            // textRegistrationMethod
            // 
            this.textRegistrationMethod.Location = new System.Drawing.Point(63, 37);
            this.textRegistrationMethod.Name = "textRegistrationMethod";
            this.textRegistrationMethod.Size = new System.Drawing.Size(138, 21);
            this.textRegistrationMethod.StyleController = this.layoutControl1;
            this.textRegistrationMethod.TabIndex = 5;
            // 
            // textSoftwareName
            // 
            this.textSoftwareName.Location = new System.Drawing.Point(63, 12);
            this.textSoftwareName.Name = "textSoftwareName";
            this.textSoftwareName.Size = new System.Drawing.Size(138, 21);
            this.textSoftwareName.StyleController = this.layoutControl1;
            this.textSoftwareName.TabIndex = 4;
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
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(213, 203);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textSoftwareName;
            this.layoutControlItem1.CustomizationFormText = "软件名称";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(193, 25);
            this.layoutControlItem1.Text = "软件名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textRegistrationMethod;
            this.layoutControlItem2.CustomizationFormText = "配准算法";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(193, 25);
            this.layoutControlItem2.Text = "配准算法";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textDiffComputer;
            this.layoutControlItem3.CustomizationFormText = "偏差计算";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(193, 25);
            this.layoutControlItem3.Text = "偏差计算";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtSurfaceReconstruct;
            this.layoutControlItem4.CustomizationFormText = "曲面重构";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 75);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(193, 108);
            this.layoutControlItem4.Text = "曲面重构";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // SoftwareFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.dockPanel1);
            this.Name = "SoftwareFrm";
            this.Text = "软件信息管理";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwarebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSurfaceReconstruct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDiffComputer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegistrationMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoftwareName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SoftwarebindingSource;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtSurfaceReconstruct;
        private DevExpress.XtraEditors.TextEdit textDiffComputer;
        private DevExpress.XtraEditors.TextEdit textRegistrationMethod;
        private DevExpress.XtraEditors.TextEdit textSoftwareName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}