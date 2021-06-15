Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextUser.Focus()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If IsUserExist(TextUser.Text, TextPassword.Text) Then
            Call Open()
            Me.Close()
        End If
    End Sub

    Private Sub Open()
        With Form1
            .ReportToolStripMenuItem.Enabled = True
            .LogoutToolStripMenuItem.Enabled = True
            .LoginToolStripMenuItem.Enabled = False
            .InsertBtn.Enabled = True
            .UpdateBtn.Enabled = True
            .DeleteBtn.Enabled = True
            .Button1.Enabled = True
            .textAlamat.Enabled = True
            .textJurusan.Enabled = True
            .textkelas.Enabled = True
            .textNama.Enabled = True
        End With
    End Sub
    Private Sub TextPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            LoginButton_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then
            TextPassword.UseSystemPasswordChar = False
        Else
            TextPassword.UseSystemPasswordChar = True
        End If

    End Sub
End Class