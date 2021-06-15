Public Class CrystalReportView


    Private Sub LoadReport()

        Try
            DBConn()
            Dim Ds As New DataSet
            Dim Report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            DataAdapter = New SqlClient.SqlDataAdapter("Select nama,kelas,jurusan,alamat from Users", Conn)
            DataAdapter.Fill(Ds)

            Report.Load("C:\Users\user\Documents\Visual Studio 2015\Projects\DataReports\DataReports\DataReport.rpt")
            Report.SetDatabaseLogon("sa", "sql")
            Report.SetDataSource(Ds.Tables("Users"))

            CrystalReportViewer1.ReportSource = Report

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadReport()
    End Sub
    Private Sub CrystalReportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub
End Class