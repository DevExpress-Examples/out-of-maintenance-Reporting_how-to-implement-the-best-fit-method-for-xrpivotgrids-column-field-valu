namespace RepPGVertHeadersHeight {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.manualDataSet1 = new RepPGVertHeadersHeight.ManualDataSet();
            this.fieldMyDateTime = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldMyRow = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldMyData = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldID = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.manualDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.Detail.HeightF = 211F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 30F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.ReportHeader.HeightF = 58F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(250F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(142F, 58F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Report";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataMember = "table";
            this.xrPivotGrid1.DataSource = this.manualDataSet1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldMyDateTime,
            this.fieldMyRow,
            this.fieldMyData,
            this.fieldID});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(566.0416F, 152.4167F);
            // 
            // manualDataSet1
            // 
            this.manualDataSet1.DataSetName = "ManualDataSet";
            // 
            // fieldMyDateTime
            // 
            this.fieldMyDateTime.AreaIndex = 1;
            this.fieldMyDateTime.Caption = "MyDateTime";
            this.fieldMyDateTime.FieldName = "MyDateTime";
            this.fieldMyDateTime.Name = "fieldMyDateTime";
            // 
            // fieldMyRow
            // 
            this.fieldMyRow.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMyRow.AreaIndex = 0;
            this.fieldMyRow.Caption = "MyRow";
            this.fieldMyRow.FieldName = "MyRow";
            this.fieldMyRow.Name = "fieldMyRow";
            // 
            // fieldMyData
            // 
            this.fieldMyData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMyData.AreaIndex = 0;
            this.fieldMyData.Caption = "MyData";
            this.fieldMyData.FieldName = "MyData";
            this.fieldMyData.Name = "fieldMyData";
            // 
            // fieldID
            // 
            this.fieldID.AreaIndex = 0;
            this.fieldID.FieldName = "ID";
            this.fieldID.Name = "fieldID";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageFooter,
            this.ReportHeader,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.Version = "12.2";
            ((System.ComponentModel.ISupportInitialize)(this.manualDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private ManualDataSet manualDataSet1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldMyDateTime;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldMyRow;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldMyData;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldID;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
    }
}
