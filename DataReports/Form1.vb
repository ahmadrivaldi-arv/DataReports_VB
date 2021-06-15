Imports System.Data.SqlClient


Public Class Form1
    Dim Conn As SqlConnection
    Dim Cmd As SqlCommand
    Dim DataReader As SqlDataReader
    Dim DataAdapter As SqlDataAdapter
    Dim DataTable As DataTable
    Dim ConnString As String

    Dim UserId, UserNama As String

    Private Sub ConnDB()

        ConnString = "data source=LAPTOP-KSGCD5K2\SQLEXPRESS; initial catalog=ReportSystem;integrated security=true"

        Conn = New SqlConnection(ConnString)

        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoadData()
        Call ConnDB()
        DataAdapter = New SqlDataAdapter("select * from Users", Conn)
        DataTable = New DataTable
        DataAdapter.Fill(DataTable)
        DataGridView1.DataSource = DataTable

        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowHeadersVisible = False
        With DataGridView1.Columns(0)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Width = 45
        End With

        With DataGridView1.Columns(2)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With DataGridView1.Columns(3)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub
    Public Sub DisableButtonNoLogin()
        With Me
            .ReportToolStripMenuItem.Enabled = False
            .LogoutToolStripMenuItem.Enabled = False
            .LoginToolStripMenuItem.Enabled = True
            .InsertBtn.Enabled = False
            .UpdateBtn.Enabled = False
            .DeleteBtn.Enabled = False
            .Button1.Enabled = False
            .textAlamat.Enabled = False
            .textJurusan.Enabled = False
            .textkelas.Enabled = False
            .textNama.Enabled = False
        End With
    End Sub

    Public Sub EnableWhenLogin()
        ReportToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim LoginForms = New LoginForm
        LoginForms.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CrPt = CrystalReportView
        CrPt.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        If textNama.Text = "" Or textkelas.Text = "" Or textJurusan.Text = "" Or textAlamat.Text = "" Then
            MessageBox.Show("Mohon isi semua form", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            InsertToTable(textNama.Text, textkelas.Text, textJurusan.Text, textAlamat.Text)
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex = -1 Then

        Else
            Dim SelectedRow = DataGridView1.Rows(e.RowIndex)
            UserId = SelectedRow.Cells(0).Value.ToString
            textNama.Text = SelectedRow.Cells(1).Value.ToString
            textkelas.Text = SelectedRow.Cells(2).Value.ToString
            textJurusan.Text = SelectedRow.Cells(3).Value.ToString
            textAlamat.Text = SelectedRow.Cells(4).Value.ToString

            StatusBar1.Panels(0).Text = "Nama: " + textNama.Text
            StatusBar1.Panels(1).Text = "Kelas: " + textkelas.Text
            StatusBar1.Panels(2).Text = "Jurusan: " + textJurusan.Text
            StatusBar1.Panels(3).Text = "Alamat: " + textAlamat.Text
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If textNama.Text = "" Or textkelas.Text = "" Or textJurusan.Text = "" Or textAlamat.Text = "" Then
            MessageBox.Show("Mohon isi semua form", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            UpdateData(textNama.Text, textkelas.Text, textJurusan.Text, textAlamat.Text, UserId)
            LoadData()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If textNama.Text = "" Or textkelas.Text = "" Or textJurusan.Text = "" Or textAlamat.Text = "" Then
            MessageBox.Show("Mohon isi semua form", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Response = MessageBox.Show("Apakah anda yakin ingin menghapus data?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If Response = DialogResult.OK Then
                DeleteData(UserId)
                LoadData()
            End If
        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call DisableButtonNoLogin()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Environment.Exit(1)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextFind.TextChanged
        Try
            ConnDB()
            DataAdapter = New SqlDataAdapter("Select * from Users where nama like '%" & TextFind.Text & "%' or kelas like '%" & TextFind.Text & "%' or jurusan like '%" & TextFind.Text & "%' or alamat like '%" & TextFind.Text & "%'", Conn)
            Dim dt As New DataTable
            DataAdapter.Fill(dt)
            DataGridView1.DataSource = dt
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        TextFind.Text = ""
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        TextFind.Text = ""
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Button1_Click(Me, EventArgs.Empty)
    End Sub
End Class
