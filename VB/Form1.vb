Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click
            CType(New ReportPrintTool(CreateReport()), ReportPrintTool).ShowPreviewDialog()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button2.Click
            CType(New ReportDesignTool(CreateReport()), ReportDesignTool).ShowDesignerDialog()
        End Sub

        Private Function CreateReport() As XtraReport
            ' Create a new report.
            Dim report As New XtraReport1()

            ' Add a script to a report's collection of scripts.
            report.ScriptsSource &= "private void xrLabel1_BeforePrint(object sender, " & _
                "System.Drawing.Printing.PrintEventArgs e) {" & Constants.vbCrLf & "  " & _
                "((XRLabel)sender).BackColor = Color.Aqua;" & Constants.vbCrLf & "}"

            ' Assign this script to a label's BeforePrint script.
            report.xrLabel1.Scripts.OnBeforePrint = "xrLabel1_BeforePrint"

            Return report
        End Function
    End Class
End Namespace