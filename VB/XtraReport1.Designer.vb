Namespace RepPGVertHeadersHeight
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Dim crossTabColumnField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
			Dim crossTabDataField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
			Dim crossTabRowField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.xrCrossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
			Me.ctcContactTitile = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.ctcUnitsInStrock = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.ctcCategoryName = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.ctcContactTitleValue = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTab1})
			Me.Detail.HeightF = 211F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.HeightF = 30F
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 58F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(250F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(142F, 58F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "Report"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.HeightF = 50F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 50F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "Northwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "UnitsInStock"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""267"" />"
			table1.Name = "Products"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ContactTitle"
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""286"" />"
			table2.Name = "Suppliers"
			columnExpression2.Table = table2
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "CategoryName"
			table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""134"" />"
			table3.Name = "Categories"
			columnExpression3.Table = table3
			column3.Expression = columnExpression3
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Name = "Products"
			relationColumnInfo1.NestedKeyColumn = "SupplierID"
			relationColumnInfo1.ParentKeyColumn = "SupplierID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "CategoryID"
			relationColumnInfo2.ParentKeyColumn = "CategoryID"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table1
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' xrCrossTab1
			' 
			Me.xrCrossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.ctcContactTitile, Me.ctcUnitsInStrock, Me.ctcCategoryName, Me.ctcContactTitleValue, Me.xrCrossTabCell5, Me.xrCrossTabCell6, Me.xrCrossTabCell7, Me.xrCrossTabCell8, Me.xrCrossTabCell9})
			Me.xrCrossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			})
			crossTabColumnField1.FieldName = "CategoryName"
			Me.xrCrossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() { crossTabColumnField1})
			crossTabDataField1.FieldName = "UnitsInStock"
			Me.xrCrossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() { crossTabDataField1})
			Me.xrCrossTab1.DataMember = "Products"
			Me.xrCrossTab1.DataSource = Me.sqlDataSource1
			Me.xrCrossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrCrossTab1.Name = "xrCrossTab1"
			Me.xrCrossTab1.OriginalPivotGridLayout = resources.GetString("xrCrossTab1.OriginalPivotGridLayout")
			Me.xrCrossTab1.PrintOptions.PrintTotalsForSingleValues = False
			Me.xrCrossTab1.PrintOptions.RepeatColumnHeaders = False
			Me.xrCrossTab1.PrintOptions.RepeatRowHeaders = False
			Me.xrCrossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)
			})
			crossTabRowField1.FieldName = "ContactTitle"
			Me.xrCrossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() { crossTabRowField1})
			Me.xrCrossTab1.SizeF = New System.Drawing.SizeF(312F, 75F)
			' 
			' ctcContactTitile
			' 
			Me.ctcContactTitile.BackColor = System.Drawing.SystemColors.Control
			Me.ctcContactTitile.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.ctcContactTitile.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.ctcContactTitile.BorderWidth = 1F
			Me.ctcContactTitile.ColumnIndex = 0
			Me.ctcContactTitile.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.ctcContactTitile.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ctcContactTitile.Name = "ctcContactTitile"
			Me.ctcContactTitile.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.ctcContactTitile.RowIndex = 0
			Me.ctcContactTitile.Text = "Contact Title"
			Me.ctcContactTitile.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' ctcUnitsInStrock
			' 
			Me.ctcUnitsInStrock.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.ctcUnitsInStrock.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.ctcUnitsInStrock.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.ctcUnitsInStrock.BorderWidth = 1F
			Me.ctcUnitsInStrock.ColumnIndex = 1
			Me.ctcUnitsInStrock.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.ctcUnitsInStrock.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.ctcUnitsInStrock.Name = "ctcUnitsInStrock"
			Me.ctcUnitsInStrock.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.ctcUnitsInStrock.RowIndex = 1
			Me.ctcUnitsInStrock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' ctcCategoryName
			' 
			Me.ctcCategoryName.BackColor = System.Drawing.SystemColors.Control
			Me.ctcCategoryName.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.ctcCategoryName.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.ctcCategoryName.BorderWidth = 1F
			Me.ctcCategoryName.ColumnIndex = 1
			Me.ctcCategoryName.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.ctcCategoryName.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ctcCategoryName.Name = "ctcCategoryName"
			Me.ctcCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.ctcCategoryName.RowIndex = 0
			Me.ctcCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' ctcContactTitleValue
			' 
			Me.ctcContactTitleValue.BackColor = System.Drawing.SystemColors.Control
			Me.ctcContactTitleValue.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.ctcContactTitleValue.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.ctcContactTitleValue.BorderWidth = 1F
			Me.ctcContactTitleValue.ColumnIndex = 0
			Me.ctcContactTitleValue.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.ctcContactTitleValue.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ctcContactTitleValue.Name = "ctcContactTitleValue"
			Me.ctcContactTitleValue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.ctcContactTitleValue.RowIndex = 1
			Me.ctcContactTitleValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell5
			' 
			Me.xrCrossTabCell5.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell5.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell5.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell5.BorderWidth = 1F
			Me.xrCrossTabCell5.ColumnIndex = 0
			Me.xrCrossTabCell5.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrCrossTabCell5.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell5.Name = "xrCrossTabCell5"
			Me.xrCrossTabCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell5.RowIndex = 2
			Me.xrCrossTabCell5.Text = "Grand Total"
			Me.xrCrossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell6
			' 
			Me.xrCrossTabCell6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell6.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell6.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell6.BorderWidth = 1F
			Me.xrCrossTabCell6.ColumnIndex = 1
			Me.xrCrossTabCell6.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrCrossTabCell6.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell6.Name = "xrCrossTabCell6"
			Me.xrCrossTabCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell6.RowIndex = 2
			Me.xrCrossTabCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell7
			' 
			Me.xrCrossTabCell7.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell7.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell7.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell7.BorderWidth = 1F
			Me.xrCrossTabCell7.ColumnIndex = 2
			Me.xrCrossTabCell7.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrCrossTabCell7.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell7.Name = "xrCrossTabCell7"
			Me.xrCrossTabCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell7.RowIndex = 0
			Me.xrCrossTabCell7.Text = "Grand Total"
			Me.xrCrossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell8
			' 
			Me.xrCrossTabCell8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell8.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell8.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell8.BorderWidth = 1F
			Me.xrCrossTabCell8.ColumnIndex = 2
			Me.xrCrossTabCell8.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrCrossTabCell8.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell8.Name = "xrCrossTabCell8"
			Me.xrCrossTabCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell8.RowIndex = 1
			Me.xrCrossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell9
			' 
			Me.xrCrossTabCell9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell9.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell9.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell9.BorderWidth = 1F
			Me.xrCrossTabCell9.ColumnIndex = 2
			Me.xrCrossTabCell9.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrCrossTabCell9.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell9.Name = "xrCrossTabCell9"
			Me.xrCrossTabCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell9.RowIndex = 2
			Me.xrCrossTabCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageFooter, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
			Me.Version = "19.2"
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrCrossTab1 As DevExpress.XtraReports.UI.XRCrossTab
		Private ctcContactTitile As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private ctcUnitsInStrock As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private ctcCategoryName As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private ctcContactTitleValue As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
	End Class
End Namespace
