Imports System.Data.SqlClient

Module DBDriver
    Public Conn As SqlConnection
    Public Cmd As SqlCommand
    Public DataAdapter As SqlDataAdapter
    Public DataReader As SqlDataReader


    Public Sub DBConn()
        Try
            Conn = New SqlConnection("data source=LAPTOP-KSGCD5K2\SQLEXPRESS; initial catalog=ReportSystem;integrated security=true")

            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub InsertToTable(nama As String, kelas As String, jurusan As String, alamat As String)
        Try
            DBConn()
            Dim Query As String = "Insert into Users([nama],[kelas],[jurusan],[alamat]) values ('" & nama & "','" & kelas & "','" & jurusan & "','" & alamat & "')"
            Cmd = New SqlCommand(Query, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data Successfully Inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show("FAILED Insert data to database", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateData(nama As String, kelas As String, jurusan As String, alamat As String, UserId As String)
        DBConn()
        Dim Query As String = "Update Users Set [nama]='" & nama & "',[kelas]='" & kelas & "',[jurusan]='" & jurusan & "',[alamat]='" & alamat & "' Where id='" & UserId & "'"
        Cmd = New SqlCommand(Query, Conn)
        Cmd.ExecuteNonQuery()
        MessageBox.Show("Data Successfully Updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub DeleteData(UserId As String)
        Try
            DBConn()
            Dim Query As String = "Delete From Users Where id='" & UserId & "'"
            Cmd = New SqlCommand(Query, Conn)
            Cmd.ExecuteNonQuery()
            'MessageBox.Show("Data Successfully Deleted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Public Function IsUserExist(username As String, password As String)
        Try
            DBConn()
            Cmd = New SqlCommand("Select username,password from tbl_login where username='" & username & "' and password='" & password & "'", Conn)
            DataReader = Cmd.ExecuteReader
            If DataReader.Read Then 'jika username dan password benar akan me return true
                Return True
            End If

            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
