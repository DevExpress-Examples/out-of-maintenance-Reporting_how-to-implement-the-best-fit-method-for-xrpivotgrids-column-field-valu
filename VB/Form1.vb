Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
' ...

Namespace RepPGVertHeadersHeight
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			pivotGridControl1.Fields("MyRow").BestFit()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim report As New XtraReport1()
			'new DevExpress.XtraReports.UI.ReportDesignTool(report).ShowDesignerDialog();
			CType(New DevExpress.XtraReports.UI.ReportPrintTool(report), DevExpress.XtraReports.UI.ReportPrintTool).ShowPreviewDialog()
		End Sub
	End Class
End Namespace