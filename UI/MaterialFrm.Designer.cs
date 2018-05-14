namespace HullShellTest.UI
{
    partial class MaterialFrm
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
            this.txtStrainOfWidthAndThickness = new DevExpress.XtraEditors.TextEdit();
            this.txtHardenablityValue = new DevExpress.XtraEditors.TextEdit();
            this.txtReductionOfArea = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimateElongation = new DevExpress.XtraEditors.TextEdit();
            this.txtTensileStrength = new DevExpress.XtraEditors.TextEdit();
            this.txtYieldSrength = new DevExpress.XtraEditors.TextEdit();
            this.txtElasticModulus = new DevExpress.XtraEditors.TextEdit();
            this.txtMaterialName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.MaterialName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ElasticModulus = new DevExpress.XtraLayout.LayoutControlItem();
            this.YieldSrength = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.MaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStrainOfWidthAndThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHardenablityValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReductionOfArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimateElongation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensileStrength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYieldSrength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElasticModulus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElasticModulus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YieldSrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ribbonControl1.Size = new System.Drawing.Size(977, 184);
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
            this.dockPanel1.ID = new System.Guid("22033566-7799-49a6-8908-9fd2509e8f3c");
            this.dockPanel1.Location = new System.Drawing.Point(0, 184);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(241, 200);
            this.dockPanel1.Size = new System.Drawing.Size(241, 485);
            this.dockPanel1.Text = "详情";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 30);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(233, 451);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtStrainOfWidthAndThickness);
            this.layoutControl1.Controls.Add(this.txtHardenablityValue);
            this.layoutControl1.Controls.Add(this.txtReductionOfArea);
            this.layoutControl1.Controls.Add(this.txtUltimateElongation);
            this.layoutControl1.Controls.Add(this.txtTensileStrength);
            this.layoutControl1.Controls.Add(this.txtYieldSrength);
            this.layoutControl1.Controls.Add(this.txtElasticModulus);
            this.layoutControl1.Controls.Add(this.txtMaterialName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(233, 451);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtStrainOfWidthAndThickness
            // 
            this.txtStrainOfWidthAndThickness.Location = new System.Drawing.Point(123, 236);
            this.txtStrainOfWidthAndThickness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStrainOfWidthAndThickness.Name = "txtStrainOfWidthAndThickness";
            this.txtStrainOfWidthAndThickness.Size = new System.Drawing.Size(98, 28);
            this.txtStrainOfWidthAndThickness.StyleController = this.layoutControl1;
            this.txtStrainOfWidthAndThickness.TabIndex = 11;
            // 
            // txtHardenablityValue
            // 
            this.txtHardenablityValue.Location = new System.Drawing.Point(123, 204);
            this.txtHardenablityValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHardenablityValue.Name = "txtHardenablityValue";
            this.txtHardenablityValue.Size = new System.Drawing.Size(98, 28);
            this.txtHardenablityValue.StyleController = this.layoutControl1;
            this.txtHardenablityValue.TabIndex = 10;
            // 
            // txtReductionOfArea
            // 
            this.txtReductionOfArea.Location = new System.Drawing.Point(123, 172);
            this.txtReductionOfArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReductionOfArea.Name = "txtReductionOfArea";
            this.txtReductionOfArea.Size = new System.Drawing.Size(98, 28);
            this.txtReductionOfArea.StyleController = this.layoutControl1;
            this.txtReductionOfArea.TabIndex = 9;
            // 
            // txtUltimateElongation
            // 
            this.txtUltimateElongation.Location = new System.Drawing.Point(123, 140);
            this.txtUltimateElongation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUltimateElongation.Name = "txtUltimateElongation";
            this.txtUltimateElongation.Size = new System.Drawing.Size(98, 28);
            this.txtUltimateElongation.StyleController = this.layoutControl1;
            this.txtUltimateElongation.TabIndex = 8;
            // 
            // txtTensileStrength
            // 
            this.txtTensileStrength.Location = new System.Drawing.Point(123, 108);
            this.txtTensileStrength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTensileStrength.Name = "txtTensileStrength";
            this.txtTensileStrength.Size = new System.Drawing.Size(98, 28);
            this.txtTensileStrength.StyleController = this.layoutControl1;
            this.txtTensileStrength.TabIndex = 7;
            // 
            // txtYieldSrength
            // 
            this.txtYieldSrength.Location = new System.Drawing.Point(123, 76);
            this.txtYieldSrength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYieldSrength.Name = "txtYieldSrength";
            this.txtYieldSrength.Size = new System.Drawing.Size(98, 28);
            this.txtYieldSrength.StyleController = this.layoutControl1;
            this.txtYieldSrength.TabIndex = 6;
            // 
            // txtElasticModulus
            // 
            this.txtElasticModulus.Location = new System.Drawing.Point(123, 44);
            this.txtElasticModulus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtElasticModulus.Name = "txtElasticModulus";
            this.txtElasticModulus.Size = new System.Drawing.Size(98, 28);
            this.txtElasticModulus.StyleController = this.layoutControl1;
            this.txtElasticModulus.TabIndex = 5;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(123, 12);
            this.txtMaterialName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(98, 28);
            this.txtMaterialName.StyleController = this.layoutControl1;
            this.txtMaterialName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.MaterialName,
            this.ElasticModulus,
            this.YieldSrength,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(233, 451);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // MaterialName
            // 
            this.MaterialName.Control = this.txtMaterialName;
            this.MaterialName.CustomizationFormText = "材料名称";
            this.MaterialName.Location = new System.Drawing.Point(0, 0);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new System.Drawing.Size(213, 32);
            this.MaterialName.Text = "材料名称";
            this.MaterialName.TextSize = new System.Drawing.Size(108, 22);
            // 
            // ElasticModulus
            // 
            this.ElasticModulus.Control = this.txtElasticModulus;
            this.ElasticModulus.CustomizationFormText = "弹性模量";
            this.ElasticModulus.Location = new System.Drawing.Point(0, 32);
            this.ElasticModulus.Name = "ElasticModulus";
            this.ElasticModulus.Size = new System.Drawing.Size(213, 32);
            this.ElasticModulus.Text = "弹性模量";
            this.ElasticModulus.TextSize = new System.Drawing.Size(108, 22);
            // 
            // YieldSrength
            // 
            this.YieldSrength.Control = this.txtYieldSrength;
            this.YieldSrength.CustomizationFormText = "屈服强度";
            this.YieldSrength.Location = new System.Drawing.Point(0, 64);
            this.YieldSrength.Name = "YieldSrength";
            this.YieldSrength.Size = new System.Drawing.Size(213, 32);
            this.YieldSrength.Text = "屈服强度";
            this.YieldSrength.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTensileStrength;
            this.layoutControlItem4.CustomizationFormText = "抗拉强度";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(213, 32);
            this.layoutControlItem4.Text = "抗拉强度";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtUltimateElongation;
            this.layoutControlItem5.CustomizationFormText = "极限伸长量";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(213, 32);
            this.layoutControlItem5.Text = "极限伸长量";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtReductionOfArea;
            this.layoutControlItem6.CustomizationFormText = "断面收缩率";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(213, 32);
            this.layoutControlItem6.Text = "断面收缩率";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtHardenablityValue;
            this.layoutControlItem7.CustomizationFormText = "硬化指数";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(213, 32);
            this.layoutControlItem7.Text = "硬化指数";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtStrainOfWidthAndThickness;
            this.layoutControlItem8.CustomizationFormText = "厚向异性系数";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 224);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(213, 207);
            this.layoutControlItem8.Text = "厚向异性系数";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(108, 22);
            // 
            // MaterialFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 669);
            this.Controls.Add(this.dockPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MaterialFrm";
            this.Text = "材料属性管理";
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStrainOfWidthAndThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHardenablityValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReductionOfArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimateElongation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensileStrength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYieldSrength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElasticModulus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElasticModulus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YieldSrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource MaterialBindingSource;
        private DevExpress.XtraEditors.TextEdit txtStrainOfWidthAndThickness;
        private DevExpress.XtraEditors.TextEdit txtHardenablityValue;
        private DevExpress.XtraEditors.TextEdit txtReductionOfArea;
        private DevExpress.XtraEditors.TextEdit txtUltimateElongation;
        private DevExpress.XtraEditors.TextEdit txtTensileStrength;
        private DevExpress.XtraEditors.TextEdit txtYieldSrength;
        private DevExpress.XtraEditors.TextEdit txtElasticModulus;
        private DevExpress.XtraEditors.TextEdit txtMaterialName;
        private DevExpress.XtraLayout.LayoutControlItem MaterialName;
        private DevExpress.XtraLayout.LayoutControlItem ElasticModulus;
        private DevExpress.XtraLayout.LayoutControlItem YieldSrength;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}