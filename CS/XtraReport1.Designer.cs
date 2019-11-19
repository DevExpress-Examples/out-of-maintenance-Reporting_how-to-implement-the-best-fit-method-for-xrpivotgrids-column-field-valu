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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCrossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.cellRowsAreaHeader = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellUnitsInStrock = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellCategoryName = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellContactTitle = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellColumnTotal = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellCategoryTotal = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellRowTotal = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellContactTotal = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.cellGrandTotal = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTab1});
            this.Detail.HeightF = 211F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrCrossTab1
            // 
            this.xrCrossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.cellRowsAreaHeader,
            this.cellUnitsInStrock,
            this.cellCategoryName,
            this.cellContactTitle,
            this.cellColumnTotal,
            this.cellCategoryTotal,
            this.cellRowTotal,
            this.cellContactTotal,
            this.cellGrandTotal});
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)});
            crossTabColumnField1.FieldName = "CategoryName";
            this.xrCrossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            crossTabDataField1.FieldName = "UnitsInStock";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.xrCrossTab1.DataMember = "Products";
            this.xrCrossTab1.DataSource = this.sqlDataSource1;
            this.xrCrossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCrossTab1.Name = "xrCrossTab1";
            this.xrCrossTab1.OriginalPivotGridLayout = resources.GetString("xrCrossTab1.OriginalPivotGridLayout");
            this.xrCrossTab1.PrintOptions.PrintTotalsForSingleValues = false;
            this.xrCrossTab1.PrintOptions.RepeatColumnHeaders = false;
            this.xrCrossTab1.PrintOptions.RepeatRowHeaders = false;
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)});
            crossTabRowField1.FieldName = "ContactTitle";
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.xrCrossTab1.SizeF = new System.Drawing.SizeF(312F, 75F);
            // 
            // cellRowsAreaHeader
            // 
            this.cellRowsAreaHeader.BackColor = System.Drawing.SystemColors.Control;
            this.cellRowsAreaHeader.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellRowsAreaHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellRowsAreaHeader.BorderWidth = 1F;
            this.cellRowsAreaHeader.ColumnIndex = 0;
            this.cellRowsAreaHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellRowsAreaHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cellRowsAreaHeader.Name = "cellRowsAreaHeader";
            this.cellRowsAreaHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellRowsAreaHeader.RowIndex = 0;
            this.cellRowsAreaHeader.Text = "Contact Title";
            this.cellRowsAreaHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellUnitsInStrock
            // 
            this.cellUnitsInStrock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cellUnitsInStrock.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellUnitsInStrock.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellUnitsInStrock.BorderWidth = 1F;
            this.cellUnitsInStrock.ColumnIndex = 1;
            this.cellUnitsInStrock.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellUnitsInStrock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cellUnitsInStrock.Name = "cellUnitsInStrock";
            this.cellUnitsInStrock.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellUnitsInStrock.RowIndex = 1;
            this.cellUnitsInStrock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellCategoryName
            // 
            this.cellCategoryName.BackColor = System.Drawing.SystemColors.Control;
            this.cellCategoryName.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellCategoryName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellCategoryName.BorderWidth = 1F;
            this.cellCategoryName.ColumnIndex = 1;
            this.cellCategoryName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellCategoryName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cellCategoryName.Name = "cellCategoryName";
            this.cellCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellCategoryName.RowIndex = 0;
            this.cellCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellContactTitle
            // 
            this.cellContactTitle.BackColor = System.Drawing.SystemColors.Control;
            this.cellContactTitle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellContactTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellContactTitle.BorderWidth = 1F;
            this.cellContactTitle.ColumnIndex = 0;
            this.cellContactTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellContactTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cellContactTitle.Name = "cellContactTitle";
            this.cellContactTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellContactTitle.RowIndex = 1;
            this.cellContactTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellColumnTotal
            // 
            this.cellColumnTotal.BackColor = System.Drawing.SystemColors.Control;
            this.cellColumnTotal.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellColumnTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellColumnTotal.BorderWidth = 1F;
            this.cellColumnTotal.ColumnIndex = 0;
            this.cellColumnTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellColumnTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cellColumnTotal.Name = "cellColumnTotal";
            this.cellColumnTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellColumnTotal.RowIndex = 2;
            this.cellColumnTotal.Text = "Grand Total";
            this.cellColumnTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellCategoryTotal
            // 
            this.cellCategoryTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cellCategoryTotal.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellCategoryTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellCategoryTotal.BorderWidth = 1F;
            this.cellCategoryTotal.ColumnIndex = 1;
            this.cellCategoryTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellCategoryTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cellCategoryTotal.Name = "cellCategoryTotal";
            this.cellCategoryTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellCategoryTotal.RowIndex = 2;
            this.cellCategoryTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellRowTotal
            // 
            this.cellRowTotal.BackColor = System.Drawing.SystemColors.Control;
            this.cellRowTotal.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellRowTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellRowTotal.BorderWidth = 1F;
            this.cellRowTotal.ColumnIndex = 2;
            this.cellRowTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellRowTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cellRowTotal.Name = "cellRowTotal";
            this.cellRowTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellRowTotal.RowIndex = 0;
            this.cellRowTotal.Text = "Grand Total";
            this.cellRowTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellContactTotal
            // 
            this.cellContactTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cellContactTotal.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellContactTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellContactTotal.BorderWidth = 1F;
            this.cellContactTotal.ColumnIndex = 2;
            this.cellContactTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellContactTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cellContactTotal.Name = "cellContactTotal";
            this.cellContactTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellContactTotal.RowIndex = 1;
            this.cellContactTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellGrandTotal
            // 
            this.cellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cellGrandTotal.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cellGrandTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cellGrandTotal.BorderWidth = 1F;
            this.cellGrandTotal.ColumnIndex = 2;
            this.cellGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cellGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cellGrandTotal.Name = "cellGrandTotal";
            this.cellGrandTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.cellGrandTotal.RowIndex = 2;
            this.cellGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Northwind";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "UnitsInStock";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"267\" />";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ContactTitle";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"286\" />";
            table2.Name = "Suppliers";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "CategoryName";
            table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table3.Name = "Categories";
            columnExpression3.Table = table3;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Name = "Products";
            relationColumnInfo1.NestedKeyColumn = "SupplierID";
            relationColumnInfo1.ParentKeyColumn = "SupplierID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "CategoryID";
            relationColumnInfo2.ParentKeyColumn = "CategoryID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            this.topMarginBand1.HeightF = 50F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 50F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageFooter,
            this.ReportHeader,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellRowsAreaHeader;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellUnitsInStrock;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellCategoryName;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellContactTitle;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellColumnTotal;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellCategoryTotal;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellRowTotal;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellContactTotal;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell cellGrandTotal;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
