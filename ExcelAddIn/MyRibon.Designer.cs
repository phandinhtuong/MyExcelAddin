﻿using System.Linq;

namespace ExcelAddIn
{
    /// <summary>
    ///       Class thuộc kiểu Ribbon (Visual Designer)
    /// </summary>
    partial class MyRibon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MyRibon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            //Properties.Resources.Culture = new System.Globalization.CultureInfo("vi-VN");
            //Properties.Resources.Culture = new System.Globalization.CultureInfo(Application.LanguageSettings.LanguageID[Office.MsoAppLanguageID.msoLanguageIDUI]);
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl2 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupImportImage = this.Factory.CreateRibbonGroup();
            this.groupAlgorithm = this.Factory.CreateRibbonGroup();
            this.dropDownColorRGB = this.Factory.CreateRibbonDropDown();
            this.editSaturationPeak = this.Factory.CreateRibbonEditBox();
            this.groupCortana = this.Factory.CreateRibbonGroup();
            this.ArrowScroll = this.Factory.CreateRibbonGroup();
            this.downScroll = this.Factory.CreateRibbonCheckBox();
            this.buttonImage2Cells = this.Factory.CreateRibbonButton();
            this.buttonColorize = this.Factory.CreateRibbonButton();
            this.buttonCortana = this.Factory.CreateRibbonButton();
            this.buttonArrowScroll = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupImportImage.SuspendLayout();
            this.groupAlgorithm.SuspendLayout();
            this.groupCortana.SuspendLayout();
            this.ArrowScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupImportImage);
            this.tab1.Groups.Add(this.groupAlgorithm);
            this.tab1.Groups.Add(this.groupCortana);
            this.tab1.Groups.Add(this.ArrowScroll);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupImportImage
            // 
            this.groupImportImage.Items.Add(this.buttonImage2Cells);
            this.groupImportImage.Label = "Import Image";
            this.groupImportImage.Name = "groupImportImage";
            // 
            // groupAlgorithm
            // 
            this.groupAlgorithm.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupAlgorithm.Items.Add(this.buttonColorize);
            this.groupAlgorithm.Items.Add(this.dropDownColorRGB);
            this.groupAlgorithm.Items.Add(this.editSaturationPeak);
            this.groupAlgorithm.Label = "Algorithm";
            this.groupAlgorithm.Name = "groupAlgorithm";
            this.groupAlgorithm.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GroupAlgorithm_DialogLauncherClick);
            // 
            // dropDownColorRGB
            // 
            ribbonDropDownItemImpl1.Label = "Đỏ";
            ribbonDropDownItemImpl1.OfficeImageId = "AppointmentColor1";
            ribbonDropDownItemImpl2.Label = "Xanh lá";
            ribbonDropDownItemImpl2.OfficeImageId = "AppointmentColor3";
            ribbonDropDownItemImpl3.Label = "Xanh dương";
            ribbonDropDownItemImpl3.OfficeImageId = "AppointmentColor2";
            ribbonDropDownItemImpl4.Label = "Xám";
            ribbonDropDownItemImpl4.OfficeImageId = "AppointmentColor4";
            this.dropDownColorRGB.Items.Add(ribbonDropDownItemImpl1);
            this.dropDownColorRGB.Items.Add(ribbonDropDownItemImpl2);
            this.dropDownColorRGB.Items.Add(ribbonDropDownItemImpl3);
            this.dropDownColorRGB.Items.Add(ribbonDropDownItemImpl4);
            this.dropDownColorRGB.Label = global::ExcelAddIn.Properties.Resources.ColorString;
            this.dropDownColorRGB.Name = "dropDownColorRGB";
            // 
            // editSaturationPeak
            // 
            this.editSaturationPeak.Label = "Cực đại";
            this.editSaturationPeak.Name = "editSaturationPeak";
            this.editSaturationPeak.Text = "255";
            // 
            // groupCortana
            // 
            this.groupCortana.DialogLauncher = ribbonDialogLauncherImpl2;
            this.groupCortana.Items.Add(this.buttonCortana);
            this.groupCortana.Label = "Cortana";
            this.groupCortana.Name = "groupCortana";
            // 
            // ArrowScroll
            // 
            this.ArrowScroll.Items.Add(this.buttonArrowScroll);
            this.ArrowScroll.Items.Add(this.downScroll);
            this.ArrowScroll.Label = "Arrow Scroll";
            this.ArrowScroll.Name = "ArrowScroll";
            // 
            // downScroll
            // 
            this.downScroll.Enabled = false;
            this.downScroll.Label = "downScroll";
            this.downScroll.Name = "downScroll";
            this.downScroll.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DownScroll_Click);
            // 
            // buttonImage2Cells
            // 
            this.buttonImage2Cells.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonImage2Cells.Description = "Haha";
            this.buttonImage2Cells.Label = "Load Image";
            this.buttonImage2Cells.Name = "buttonImage2Cells";
            this.buttonImage2Cells.OfficeImageId = "AllCategories";
            this.buttonImage2Cells.ScreenTip = "Chuyển ảnh thành cell";
            this.buttonImage2Cells.ShowImage = true;
            this.buttonImage2Cells.SuperTip = "Mỗi pixcel ảnh sẽ trở thành một cell trên excel. Ảnh được tự động co sao cho số đ" +
    "iểm ảnh không quá 82455 do giới hạn của Excel";
            this.buttonImage2Cells.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonImage2Cells_Click);
            // 
            // buttonColorize
            // 
            this.buttonColorize.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonColorize.Label = global::ExcelAddIn.Properties.Resources.String1;
            this.buttonColorize.Name = "buttonColorize";
            this.buttonColorize.OfficeImageId = "BlackAndWhiteLightGrayscale";
            this.buttonColorize.ScreenTip = "Màu hóa ma trận giá trị";
            this.buttonColorize.ShowImage = true;
            this.buttonColorize.SuperTip = "Lựa chọn một bảng, sau đó bấm nút Màu hóa. Các cell trong bảng sẽ được tô màu với" +
    " mức xám thay đổi  từ màu đen (0) tới mức cực đại, của màu chỉ định trong dropbo" +
    "x";
            this.buttonColorize.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonColorize_Click);
            // 
            // buttonCortana
            // 
            this.buttonCortana.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCortana.Description = "???";
            this.buttonCortana.Label = "Cortana";
            this.buttonCortana.Name = "buttonCortana";
            this.buttonCortana.OfficeImageId = "AllCategories";
            this.buttonCortana.ScreenTip = "Cortana - Speech recognition";
            this.buttonCortana.ShowImage = true;
            this.buttonCortana.SuperTip = "Speech recognition";
            this.buttonCortana.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonCortana_Click);
            // 
            // buttonArrowScroll
            // 
            this.buttonArrowScroll.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonArrowScroll.Label = "Down and Scroll";
            this.buttonArrowScroll.Name = "buttonArrowScroll";
            this.buttonArrowScroll.OfficeImageId = "AllCategories";
            this.buttonArrowScroll.ShowImage = true;
            this.buttonArrowScroll.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonArrowScroll_Click);
            // 
            // MyRibon
            // 
            this.Name = "MyRibon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MyRibon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupImportImage.ResumeLayout(false);
            this.groupImportImage.PerformLayout();
            this.groupAlgorithm.ResumeLayout(false);
            this.groupAlgorithm.PerformLayout();
            this.groupCortana.ResumeLayout(false);
            this.groupCortana.PerformLayout();
            this.ArrowScroll.ResumeLayout(false);
            this.ArrowScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupImportImage;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonImage2Cells;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupAlgorithm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonColorize;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownColorRGB;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editSaturationPeak;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCortana;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCortana;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ArrowScroll;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonArrowScroll;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox downScroll;
    }

    partial class ThisRibbonCollection
    {
        internal MyRibon MyRibon
        {
            get { return this.GetRibbon<MyRibon>(); }
        }
    }
}
