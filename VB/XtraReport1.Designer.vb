Imports Microsoft.VisualBasic
Imports System
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
			Me.manualDataSet1 = New RepPGVertHeadersHeight.ManualDataSet()
			Me.fieldMyDateTime = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldMyRow = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldMyData = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldID = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			CType(Me.manualDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
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
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' xrPivotGrid1
			' 
			Me.xrPivotGrid1.DataMember = "table"
			Me.xrPivotGrid1.DataSource = Me.manualDataSet1
			Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.fieldMyDateTime, Me.fieldMyRow, Me.fieldMyData, Me.fieldID})
			Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrPivotGrid1.Name = "xrPivotGrid1"
			Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(566.0416F, 152.4167F)
			' 
			' manualDataSet1
			' 
			Me.manualDataSet1.DataSetName = "ManualDataSet"
			' 
			' fieldMyDateTime
			' 
			Me.fieldMyDateTime.AreaIndex = 1
			Me.fieldMyDateTime.Caption = "MyDateTime"
			Me.fieldMyDateTime.FieldName = "MyDateTime"
			Me.fieldMyDateTime.Name = "fieldMyDateTime"
			' 
			' fieldMyRow
			' 
			Me.fieldMyRow.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldMyRow.AreaIndex = 0
			Me.fieldMyRow.Caption = "MyRow"
			Me.fieldMyRow.FieldName = "MyRow"
			Me.fieldMyRow.Name = "fieldMyRow"
			' 
			' fieldMyData
			' 
			Me.fieldMyData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldMyData.AreaIndex = 0
			Me.fieldMyData.Caption = "MyData"
			Me.fieldMyData.FieldName = "MyData"
			Me.fieldMyData.Name = "fieldMyData"
			' 
			' fieldID
			' 
			Me.fieldID.AreaIndex = 0
			Me.fieldID.FieldName = "ID"
			Me.fieldID.Name = "fieldID"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageFooter, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.Version = "12.2"
			CType(Me.manualDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
		Private manualDataSet1 As ManualDataSet
		Private fieldMyDateTime As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldMyRow As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldMyData As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldID As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
	End Class
End Namespace
