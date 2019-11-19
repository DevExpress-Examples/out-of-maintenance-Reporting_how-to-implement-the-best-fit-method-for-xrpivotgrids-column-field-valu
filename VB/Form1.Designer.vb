Namespace RepPGVertHeadersHeight
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldContactTitle1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitsInStock1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.tableLayoutPanel1.SetColumnSpan(Me.pivotGridControl1, 2)
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataMember = "Products"
			Me.pivotGridControl1.DataSource = Me.sqlDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName1, Me.fieldContactTitle1, Me.fieldUnitsInStock1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(3, 3)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(745, 346)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "Northwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryName"
			table1.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""172"" />"
			table1.Name = "Categories"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ContactTitle"
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""286"" />"
			table2.Name = "Suppliers"
			columnExpression2.Table = table2
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "UnitsInStock"
			table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""267"" />"
			table3.Name = "Products"
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
			join1.Parent = table3
			relationColumnInfo2.NestedKeyColumn = "CategoryID"
			relationColumnInfo2.ParentKeyColumn = "CategoryID"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table1
			join2.Parent = table3
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Tables.Add(table3)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.Caption = "Category Name"
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' fieldContactTitle1
			' 
			Me.fieldContactTitle1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldContactTitle1.AreaIndex = 0
			Me.fieldContactTitle1.Caption = "Contact Title"
			Me.fieldContactTitle1.FieldName = "ContactTitle"
			Me.fieldContactTitle1.Name = "fieldContactTitle1"
			' 
			' fieldUnitsInStock1
			' 
			Me.fieldUnitsInStock1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitsInStock1.AreaIndex = 0
			Me.fieldUnitsInStock1.Caption = "Units In Stock"
			Me.fieldUnitsInStock1.FieldName = "UnitsInStock"
			Me.fieldUnitsInStock1.Name = "fieldUnitsInStock1"
			' 
			' button1
			' 
			Me.button1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.button1.Location = New System.Drawing.Point(106, 355)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(162, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Best Fit (Category Name)"
			Me.button1.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button1.Click += new System.EventHandler(this.button1_Click);
			' 
			' button2
			' 
			Me.button2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.button2.Location = New System.Drawing.Point(483, 355)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(159, 23)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Preview (with Best Fit)"
			Me.button2.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button2.Click += new System.EventHandler(this.button2_Click);
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.pivotGridControl1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.button2, 1, 1)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(751, 381)
			Me.tableLayoutPanel1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(751, 381)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldContactTitle1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitsInStock1 As DevExpress.XtraPivotGrid.PivotGridField
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	End Class
End Namespace

