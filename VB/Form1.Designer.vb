Imports Microsoft.VisualBasic
Imports System
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
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.manualDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.fieldID = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMyDateTime = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMyRow = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMyData = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.manualDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataMember = "table"
			Me.pivotGridControl1.DataSource = Me.manualDataSetBindingSource
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldID, Me.fieldMyDateTime, Me.fieldMyRow, Me.fieldMyData})
			Me.pivotGridControl1.Location = New System.Drawing.Point(72, 57)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(592, 200)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' manualDataSetBindingSource
			' 
			Me.manualDataSetBindingSource.DataSource = GetType(RepPGVertHeadersHeight.ManualDataSet)
			Me.manualDataSetBindingSource.Position = 0
			' 
			' fieldID
			' 
			Me.fieldID.AreaIndex = 0
			Me.fieldID.Caption = "ID"
			Me.fieldID.FieldName = "ID"
			Me.fieldID.Name = "fieldID"
			' 
			' fieldMyDateTime
			' 
			Me.fieldMyDateTime.AreaIndex = 1
			Me.fieldMyDateTime.Caption = "My Date Time"
			Me.fieldMyDateTime.FieldName = "MyDateTime"
			Me.fieldMyDateTime.Name = "fieldMyDateTime"
			' 
			' fieldMyRow
			' 
			Me.fieldMyRow.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldMyRow.AreaIndex = 0
			Me.fieldMyRow.Caption = "My Row"
			Me.fieldMyRow.FieldName = "MyRow"
			Me.fieldMyRow.Name = "fieldMyRow"
			' 
			' fieldMyData
			' 
			Me.fieldMyData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldMyData.AreaIndex = 0
			Me.fieldMyData.Caption = "My Data"
			Me.fieldMyData.FieldName = "MyData"
			Me.fieldMyData.Name = "fieldMyData"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(166, 314)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "BestFit"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(524, 313)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 23)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Preview"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(751, 381)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.manualDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private manualDataSetBindingSource As System.Windows.Forms.BindingSource
		Private fieldID As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMyDateTime As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMyRow As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMyData As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace

