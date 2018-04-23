Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
' ...

Namespace RepPGVertHeadersHeight
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
			xrPivotGrid1.BestFit(fieldMyRow)
		End Sub
	End Class

	Public Class ManualDataSet
		Inherits DataSet
		Public Sub New()
			MyBase.New()
			Dim table As New DataTable("table")

			DataSetName = "ManualDataSet"

			table.Columns.Add("ID", GetType(Int32))
			table.Columns.Add("MyDateTime", GetType(DateTime))
			table.Columns.Add("MyRow", GetType(String))
			table.Columns.Add("MyData", GetType(Double))
			'table.Constraints.Add("IDPK", table.Columns["ID"], true);

			Tables.AddRange(New DataTable() { table })

			CreateData()
		End Sub

		Public Sub CreateData()
			Dim table As DataTable = Tables("table")

			table.Rows.Add(New Object() { 0, DateTime.Today, "AA", 103 })
			table.Rows.Add(New Object() { 0, DateTime.Today, "BSD", 32 })
			table.Rows.Add(New Object() { 0, DateTime.Today, "FWEC", 341 })

			table.Rows.Add(New Object() { 1, DateTime.Today, "AA", 52 })
			table.Rows.Add(New Object() { 1, DateTime.Today, "BSD", 2 })
			table.Rows.Add(New Object() { 1, DateTime.Today, "FWEC", 12 })

			table.Rows.Add(New Object() { 2, DateTime.Today, "AA", 12 })
			table.Rows.Add(New Object() { 2, DateTime.Today, "BSD", 43 })
			table.Rows.Add(New Object() { 2, DateTime.Today, "FWEC", 12 })
		End Sub

		#Region "Disable Serialization for Tables and Relations"
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Tables() As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Relations() As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property
		#End Region ' Disable Serialization for Tables and Relations
	End Class

End Namespace
