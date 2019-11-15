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
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrCrossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.ctcContactTitile = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.ctcUnitsInStrock = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.ctcCategoryName = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.ctcContactTitleValue = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.xrCrossTabCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
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
            // xrCrossTab1
            // 
            this.xrCrossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ctcContactTitile,
            this.ctcUnitsInStrock,
            this.ctcCategoryName,
            this.ctcContactTitleValue,
            this.xrCrossTabCell5,
            this.xrCrossTabCell6,
            this.xrCrossTabCell7,
            this.xrCrossTabCell8,
            this.xrCrossTabCell9});
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
            // ctcContactTitile
            // 
            this.ctcContactTitile.BackColor = System.Drawing.SystemColors.Control;
            this.ctcContactTitile.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ctcContactTitile.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ctcContactTitile.BorderWidth = 1F;
            this.ctcContactTitile.ColumnIndex = 0;
            this.ctcContactTitile.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ctcContactTitile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctcContactTitile.Name = "ctcContactTitile";
            this.ctcContactTitile.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.ctcContactTitile.RowIndex = 0;
            this.ctcContactTitile.Text = "Contact Title";
            this.ctcContactTitile.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ctcUnitsInStrock
            // 
            this.ctcUnitsInStrock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctcUnitsInStrock.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ctcUnitsInStrock.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ctcUnitsInStrock.BorderWidth = 1F;
            this.ctcUnitsInStrock.ColumnIndex = 1;
            this.ctcUnitsInStrock.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ctcUnitsInStrock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctcUnitsInStrock.Name = "ctcUnitsInStrock";
            this.ctcUnitsInStrock.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.ctcUnitsInStrock.RowIndex = 1;
            this.ctcUnitsInStrock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ctcCategoryName
            // 
            this.ctcCategoryName.BackColor = System.Drawing.SystemColors.Control;
            this.ctcCategoryName.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ctcCategoryName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ctcCategoryName.BorderWidth = 1F;
            this.ctcCategoryName.ColumnIndex = 1;
            this.ctcCategoryName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ctcCategoryName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctcCategoryName.Name = "ctcCategoryName";
            this.ctcCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.ctcCategoryName.RowIndex = 0;
            this.ctcCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ctcContactTitleValue
            // 
            this.ctcContactTitleValue.BackColor = System.Drawing.SystemColors.Control;
            this.ctcContactTitleValue.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ctcContactTitleValue.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ctcContactTitleValue.BorderWidth = 1F;
            this.ctcContactTitleValue.ColumnIndex = 0;
            this.ctcContactTitleValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ctcContactTitleValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctcContactTitleValue.Name = "ctcContactTitleValue";
            this.ctcContactTitleValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.ctcContactTitleValue.RowIndex = 1;
            this.ctcContactTitleValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrCrossTabCell5
            // 
            this.xrCrossTabCell5.BackColor = System.Drawing.SystemColors.Control;
            this.xrCrossTabCell5.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.xrCrossTabCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell5.BorderWidth = 1F;
            this.xrCrossTabCell5.ColumnIndex = 0;
            this.xrCrossTabCell5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrCrossTabCell5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xrCrossTabCell5.Name = "xrCrossTabCell5";
            this.xrCrossTabCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrCrossTabCell5.RowIndex = 2;
            this.xrCrossTabCell5.Text = "Grand Total";
            this.xrCrossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrCrossTabCell6
            // 
            this.xrCrossTabCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrCrossTabCell6.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.xrCrossTabCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell6.BorderWidth = 1F;
            this.xrCrossTabCell6.ColumnIndex = 1;
            this.xrCrossTabCell6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrCrossTabCell6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrCrossTabCell6.Name = "xrCrossTabCell6";
            this.xrCrossTabCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrCrossTabCell6.RowIndex = 2;
            this.xrCrossTabCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrCrossTabCell7
            // 
            this.xrCrossTabCell7.BackColor = System.Drawing.SystemColors.Control;
            this.xrCrossTabCell7.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.xrCrossTabCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell7.BorderWidth = 1F;
            this.xrCrossTabCell7.ColumnIndex = 2;
            this.xrCrossTabCell7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrCrossTabCell7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xrCrossTabCell7.Name = "xrCrossTabCell7";
            this.xrCrossTabCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrCrossTabCell7.RowIndex = 0;
            this.xrCrossTabCell7.Text = "Grand Total";
            this.xrCrossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrCrossTabCell8
            // 
            this.xrCrossTabCell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrCrossTabCell8.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.xrCrossTabCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell8.BorderWidth = 1F;
            this.xrCrossTabCell8.ColumnIndex = 2;
            this.xrCrossTabCell8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrCrossTabCell8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrCrossTabCell8.Name = "xrCrossTabCell8";
            this.xrCrossTabCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrCrossTabCell8.RowIndex = 1;
            this.xrCrossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrCrossTabCell9
            // 
            this.xrCrossTabCell9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrCrossTabCell9.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.xrCrossTabCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrCrossTabCell9.BorderWidth = 1F;
            this.xrCrossTabCell9.ColumnIndex = 2;
            this.xrCrossTabCell9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrCrossTabCell9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrCrossTabCell9.Name = "xrCrossTabCell9";
            this.xrCrossTabCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrCrossTabCell9.RowIndex = 2;
            this.xrCrossTabCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell ctcContactTitile;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell ctcUnitsInStrock;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell ctcCategoryName;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell ctcContactTitleValue;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell xrCrossTabCell9;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
