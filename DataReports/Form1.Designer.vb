<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textkelas = New System.Windows.Forms.TextBox()
        Me.textNama = New System.Windows.Forms.TextBox()
        Me.textAlamat = New System.Windows.Forms.TextBox()
        Me.textJurusan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.InsertBtn = New System.Windows.Forms.Button()
        Me.TextFind = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(648, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Enabled = False
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Enabled = False
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(609, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(609, 250)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 372)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Users"
        '
        'textkelas
        '
        Me.textkelas.Enabled = False
        Me.textkelas.Location = New System.Drawing.Point(161, 52)
        Me.textkelas.Name = "textkelas"
        Me.textkelas.Size = New System.Drawing.Size(131, 20)
        Me.textkelas.TabIndex = 2
        '
        'textNama
        '
        Me.textNama.Enabled = False
        Me.textNama.Location = New System.Drawing.Point(7, 51)
        Me.textNama.Name = "textNama"
        Me.textNama.Size = New System.Drawing.Size(131, 20)
        Me.textNama.TabIndex = 1
        '
        'textAlamat
        '
        Me.textAlamat.Enabled = False
        Me.textAlamat.Location = New System.Drawing.Point(453, 52)
        Me.textAlamat.Name = "textAlamat"
        Me.textAlamat.Size = New System.Drawing.Size(166, 20)
        Me.textAlamat.TabIndex = 4
        '
        'textJurusan
        '
        Me.textJurusan.Enabled = False
        Me.textJurusan.FormattingEnabled = True
        Me.textJurusan.Items.AddRange(New Object() {"TKJ", "MM", "BDP", "TELIN", "FILM", "AKL", "OTKP", "TATABOGA"})
        Me.textJurusan.Location = New System.Drawing.Point(308, 52)
        Me.textJurusan.Name = "textJurusan"
        Me.textJurusan.Size = New System.Drawing.Size(131, 20)
        Me.textJurusan.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(451, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alamat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.textJurusan)
        Me.GroupBox2.Controls.Add(Me.textAlamat)
        Me.GroupBox2.Controls.Add(Me.textNama)
        Me.GroupBox2.Controls.Add(Me.textkelas)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(628, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Field"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(227, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "System Data Report"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Enabled = False
        Me.DeleteBtn.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(465, 129)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(166, 33)
        Me.DeleteBtn.TabIndex = 7
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Enabled = False
        Me.UpdateBtn.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(320, 129)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(131, 33)
        Me.UpdateBtn.TabIndex = 6
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'InsertBtn
        '
        Me.InsertBtn.Enabled = False
        Me.InsertBtn.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertBtn.Location = New System.Drawing.Point(174, 129)
        Me.InsertBtn.Name = "InsertBtn"
        Me.InsertBtn.Size = New System.Drawing.Size(131, 33)
        Me.InsertBtn.TabIndex = 5
        Me.InsertBtn.Text = "Insert"
        Me.InsertBtn.UseVisualStyleBackColor = True
        '
        'TextFind
        '
        Me.TextFind.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFind.Location = New System.Drawing.Point(6, 14)
        Me.TextFind.Name = "TextFind"
        Me.TextFind.Size = New System.Drawing.Size(146, 22)
        Me.TextFind.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.TextFind)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(609, 44)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Find"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(158, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StatusBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 558)
        Me.Panel1.TabIndex = 8
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Text = "Alamat:"
        Me.StatusBarPanel4.Width = 67
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "Jurusan:"
        Me.StatusBarPanel3.Width = 150
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "Kelas:"
        Me.StatusBarPanel2.Width = 150
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Nama:"
        Me.StatusBarPanel1.ToolTipText = "Nama User"
        Me.StatusBarPanel1.Width = 170
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 536)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(648, 22)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 558)
        Me.Controls.Add(Me.InsertBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextFind As TextBox
    Friend WithEvents textkelas As TextBox
    Friend WithEvents textNama As TextBox
    Friend WithEvents textAlamat As TextBox
    Friend WithEvents textJurusan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents InsertBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusBar1 As StatusBar
    Friend WithEvents StatusBarPanel1 As StatusBarPanel
    Friend WithEvents StatusBarPanel2 As StatusBarPanel
    Friend WithEvents StatusBarPanel3 As StatusBarPanel
    Friend WithEvents StatusBarPanel4 As StatusBarPanel
End Class
