<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogLibrarian
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelAdd = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.LibrarianAvatar = New System.Windows.Forms.PictureBox()
        Me.panelEdit = New System.Windows.Forms.Panel()
        Me.lblEditID = New System.Windows.Forms.Label()
        Me.txtEditPassword = New System.Windows.Forms.TextBox()
        Me.txtEditAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEditContact = New System.Windows.Forms.TextBox()
        Me.txtEditUsername = New System.Windows.Forms.TextBox()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.LibrarianEditAvatar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.panelAdd.SuspendLayout()
        CType(Me.LibrarianAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEdit.SuspendLayout()
        CType(Me.LibrarianEditAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 36)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Location = New System.Drawing.Point(289, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 36)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(11, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Librarian Information"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Location = New System.Drawing.Point(169, 406)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(146, 30)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(13, 406)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 30)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Firebrick
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.Location = New System.Drawing.Point(168, 406)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(146, 30)
        Me.btnEdit.TabIndex = 49
        Me.btnEdit.Text = "Save Changes"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Location = New System.Drawing.Point(0, 452)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(329, 3)
        Me.Panel4.TabIndex = 76
        '
        'panelAdd
        '
        Me.panelAdd.BackColor = System.Drawing.Color.Transparent
        Me.panelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelAdd.Controls.Add(Me.lblID)
        Me.panelAdd.Controls.Add(Me.txtPassword)
        Me.panelAdd.Controls.Add(Me.txtAddress)
        Me.panelAdd.Controls.Add(Me.Label7)
        Me.panelAdd.Controls.Add(Me.Label6)
        Me.panelAdd.Controls.Add(Me.Label5)
        Me.panelAdd.Controls.Add(Me.Label4)
        Me.panelAdd.Controls.Add(Me.Label2)
        Me.panelAdd.Controls.Add(Me.txtContact)
        Me.panelAdd.Controls.Add(Me.txtUsername)
        Me.panelAdd.Controls.Add(Me.txtName)
        Me.panelAdd.Controls.Add(Me.LibrarianAvatar)
        Me.panelAdd.Location = New System.Drawing.Point(13, 36)
        Me.panelAdd.Name = "panelAdd"
        Me.panelAdd.Size = New System.Drawing.Size(302, 364)
        Me.panelAdd.TabIndex = 50
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(132, 108)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(44, 17)
        Me.lblID.TabIndex = 75
        Me.lblID.Text = "0000"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(33, 281)
        Me.txtPassword.MaxLength = 40
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(235, 21)
        Me.txtPassword.TabIndex = 74
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(33, 327)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(235, 21)
        Me.txtAddress.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Password*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Username*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Name*"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(33, 189)
        Me.txtContact.MaxLength = 13
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(235, 21)
        Me.txtContact.TabIndex = 67
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(33, 235)
        Me.txtUsername.MaxLength = 15
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(235, 21)
        Me.txtUsername.TabIndex = 65
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(33, 143)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(235, 21)
        Me.txtName.TabIndex = 64
        '
        'LibrarianAvatar
        '
        Me.LibrarianAvatar.BackColor = System.Drawing.Color.Gainsboro
        Me.LibrarianAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LibrarianAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibrarianAvatar.Image = Global.Library_Management_System.My.Resources.Resources.avatar___Copy
        Me.LibrarianAvatar.InitialImage = Global.Library_Management_System.My.Resources.Resources.avatar___Copy
        Me.LibrarianAvatar.Location = New System.Drawing.Point(113, 24)
        Me.LibrarianAvatar.Name = "LibrarianAvatar"
        Me.LibrarianAvatar.Size = New System.Drawing.Size(80, 80)
        Me.LibrarianAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LibrarianAvatar.TabIndex = 55
        Me.LibrarianAvatar.TabStop = False
        '
        'panelEdit
        '
        Me.panelEdit.BackColor = System.Drawing.Color.Transparent
        Me.panelEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelEdit.Controls.Add(Me.lblEditID)
        Me.panelEdit.Controls.Add(Me.txtEditPassword)
        Me.panelEdit.Controls.Add(Me.txtEditAddress)
        Me.panelEdit.Controls.Add(Me.Label8)
        Me.panelEdit.Controls.Add(Me.Label9)
        Me.panelEdit.Controls.Add(Me.Label10)
        Me.panelEdit.Controls.Add(Me.Label11)
        Me.panelEdit.Controls.Add(Me.Label12)
        Me.panelEdit.Controls.Add(Me.txtEditContact)
        Me.panelEdit.Controls.Add(Me.txtEditUsername)
        Me.panelEdit.Controls.Add(Me.txtEditName)
        Me.panelEdit.Controls.Add(Me.LibrarianEditAvatar)
        Me.panelEdit.Location = New System.Drawing.Point(13, 36)
        Me.panelEdit.Name = "panelEdit"
        Me.panelEdit.Size = New System.Drawing.Size(302, 364)
        Me.panelEdit.TabIndex = 77
        '
        'lblEditID
        '
        Me.lblEditID.AutoSize = True
        Me.lblEditID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditID.Location = New System.Drawing.Point(132, 108)
        Me.lblEditID.Name = "lblEditID"
        Me.lblEditID.Size = New System.Drawing.Size(44, 17)
        Me.lblEditID.TabIndex = 75
        Me.lblEditID.Text = "0000"
        '
        'txtEditPassword
        '
        Me.txtEditPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditPassword.ForeColor = System.Drawing.Color.Black
        Me.txtEditPassword.Location = New System.Drawing.Point(33, 281)
        Me.txtEditPassword.MaxLength = 40
        Me.txtEditPassword.Name = "txtEditPassword"
        Me.txtEditPassword.Size = New System.Drawing.Size(235, 21)
        Me.txtEditPassword.TabIndex = 74
        '
        'txtEditAddress
        '
        Me.txtEditAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditAddress.ForeColor = System.Drawing.Color.Black
        Me.txtEditAddress.Location = New System.Drawing.Point(33, 327)
        Me.txtEditAddress.Name = "txtEditAddress"
        Me.txtEditAddress.Size = New System.Drawing.Size(235, 21)
        Me.txtEditAddress.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Password*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Username*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Contact"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Name*"
        '
        'txtEditContact
        '
        Me.txtEditContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditContact.ForeColor = System.Drawing.Color.Black
        Me.txtEditContact.Location = New System.Drawing.Point(33, 189)
        Me.txtEditContact.MaxLength = 13
        Me.txtEditContact.Name = "txtEditContact"
        Me.txtEditContact.Size = New System.Drawing.Size(235, 21)
        Me.txtEditContact.TabIndex = 67
        '
        'txtEditUsername
        '
        Me.txtEditUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditUsername.ForeColor = System.Drawing.Color.Black
        Me.txtEditUsername.Location = New System.Drawing.Point(33, 235)
        Me.txtEditUsername.MaxLength = 15
        Me.txtEditUsername.Name = "txtEditUsername"
        Me.txtEditUsername.Size = New System.Drawing.Size(235, 21)
        Me.txtEditUsername.TabIndex = 65
        '
        'txtEditName
        '
        Me.txtEditName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditName.ForeColor = System.Drawing.Color.Black
        Me.txtEditName.Location = New System.Drawing.Point(33, 143)
        Me.txtEditName.MaxLength = 30
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(235, 21)
        Me.txtEditName.TabIndex = 64
        '
        'LibrarianEditAvatar
        '
        Me.LibrarianEditAvatar.BackColor = System.Drawing.Color.Gainsboro
        Me.LibrarianEditAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LibrarianEditAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LibrarianEditAvatar.Image = Global.Library_Management_System.My.Resources.Resources.avatar___Copy
        Me.LibrarianEditAvatar.InitialImage = Nothing
        Me.LibrarianEditAvatar.Location = New System.Drawing.Point(113, 24)
        Me.LibrarianEditAvatar.Name = "LibrarianEditAvatar"
        Me.LibrarianEditAvatar.Size = New System.Drawing.Size(80, 80)
        Me.LibrarianEditAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LibrarianEditAvatar.TabIndex = 55
        Me.LibrarianEditAvatar.TabStop = False
        '
        'dialogLibrarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 455)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.panelAdd)
        Me.Controls.Add(Me.panelEdit)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dialogLibrarian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formAddBooks"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelAdd.ResumeLayout(False)
        Me.panelAdd.PerformLayout()
        CType(Me.LibrarianAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEdit.ResumeLayout(False)
        Me.panelEdit.PerformLayout()
        CType(Me.LibrarianEditAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents LibrarianAvatar As PictureBox
    Friend WithEvents panelAdd As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblID As Label
    Friend WithEvents panelEdit As Panel
    Friend WithEvents lblEditID As Label
    Friend WithEvents txtEditPassword As TextBox
    Friend WithEvents txtEditAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEditContact As TextBox
    Friend WithEvents txtEditUsername As TextBox
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents LibrarianEditAvatar As PictureBox
End Class
