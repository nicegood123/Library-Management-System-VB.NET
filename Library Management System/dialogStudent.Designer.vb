<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogStudent
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
        Me.panelAdd = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.StudentAvatar = New System.Windows.Forms.PictureBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.panelEdit = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEditID = New System.Windows.Forms.Label()
        Me.txtEditContact = New System.Windows.Forms.TextBox()
        Me.StudentEditAvatar = New System.Windows.Forms.PictureBox()
        Me.txtEditAddress = New System.Windows.Forms.TextBox()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panelAdd.SuspendLayout()
        CType(Me.StudentAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEdit.SuspendLayout()
        CType(Me.StudentEditAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Student Information"
        '
        'panelAdd
        '
        Me.panelAdd.BackColor = System.Drawing.Color.Transparent
        Me.panelAdd.Controls.Add(Me.Label9)
        Me.panelAdd.Controls.Add(Me.Label11)
        Me.panelAdd.Controls.Add(Me.Label12)
        Me.panelAdd.Controls.Add(Me.lblID)
        Me.panelAdd.Controls.Add(Me.txtContact)
        Me.panelAdd.Controls.Add(Me.StudentAvatar)
        Me.panelAdd.Controls.Add(Me.txtAddress)
        Me.panelAdd.Controls.Add(Me.txtName)
        Me.panelAdd.Location = New System.Drawing.Point(13, 36)
        Me.panelAdd.Name = "panelAdd"
        Me.panelAdd.Size = New System.Drawing.Size(302, 273)
        Me.panelAdd.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Contact*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 17)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Name*"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(123, 108)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(62, 17)
        Me.lblID.TabIndex = 76
        Me.lblID.Text = "000000"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(33, 189)
        Me.txtContact.MaxLength = 13
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(235, 21)
        Me.txtContact.TabIndex = 56
        '
        'StudentAvatar
        '
        Me.StudentAvatar.BackColor = System.Drawing.Color.Gainsboro
        Me.StudentAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StudentAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentAvatar.Image = Global.Library_Management_System.My.Resources.Resources.avatar___Copy
        Me.StudentAvatar.InitialImage = Global.Library_Management_System.My.Resources.Resources.avatar___Copy
        Me.StudentAvatar.Location = New System.Drawing.Point(113, 24)
        Me.StudentAvatar.Name = "StudentAvatar"
        Me.StudentAvatar.Size = New System.Drawing.Size(80, 80)
        Me.StudentAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudentAvatar.TabIndex = 55
        Me.StudentAvatar.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(33, 235)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(235, 21)
        Me.txtAddress.TabIndex = 53
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(33, 143)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(235, 21)
        Me.txtName.TabIndex = 52
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Location = New System.Drawing.Point(0, 362)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(329, 3)
        Me.Panel4.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Location = New System.Drawing.Point(169, 316)
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
        Me.btnCancel.Location = New System.Drawing.Point(13, 316)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 30)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'panelEdit
        '
        Me.panelEdit.BackColor = System.Drawing.Color.Transparent
        Me.panelEdit.Controls.Add(Me.Label2)
        Me.panelEdit.Controls.Add(Me.Label4)
        Me.panelEdit.Controls.Add(Me.Label1)
        Me.panelEdit.Controls.Add(Me.lblEditID)
        Me.panelEdit.Controls.Add(Me.txtEditContact)
        Me.panelEdit.Controls.Add(Me.StudentEditAvatar)
        Me.panelEdit.Controls.Add(Me.txtEditAddress)
        Me.panelEdit.Controls.Add(Me.txtEditName)
        Me.panelEdit.Location = New System.Drawing.Point(13, 36)
        Me.panelEdit.Name = "panelEdit"
        Me.panelEdit.Size = New System.Drawing.Size(302, 273)
        Me.panelEdit.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Contact*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Name*"
        '
        'lblEditID
        '
        Me.lblEditID.AutoSize = True
        Me.lblEditID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditID.Location = New System.Drawing.Point(123, 108)
        Me.lblEditID.Name = "lblEditID"
        Me.lblEditID.Size = New System.Drawing.Size(62, 17)
        Me.lblEditID.TabIndex = 77
        Me.lblEditID.Text = "000000"
        '
        'txtEditContact
        '
        Me.txtEditContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditContact.ForeColor = System.Drawing.Color.Black
        Me.txtEditContact.Location = New System.Drawing.Point(33, 189)
        Me.txtEditContact.Name = "txtEditContact"
        Me.txtEditContact.Size = New System.Drawing.Size(235, 21)
        Me.txtEditContact.TabIndex = 61
        '
        'StudentEditAvatar
        '
        Me.StudentEditAvatar.BackColor = System.Drawing.Color.Gainsboro
        Me.StudentEditAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StudentEditAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentEditAvatar.Image = Global.Library_Management_System.My.Resources.Resources.avatar___Copy
        Me.StudentEditAvatar.InitialImage = Global.Library_Management_System.My.Resources.Resources.avatar___Copy
        Me.StudentEditAvatar.Location = New System.Drawing.Point(113, 24)
        Me.StudentEditAvatar.Name = "StudentEditAvatar"
        Me.StudentEditAvatar.Size = New System.Drawing.Size(80, 80)
        Me.StudentEditAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudentEditAvatar.TabIndex = 60
        Me.StudentEditAvatar.TabStop = False
        '
        'txtEditAddress
        '
        Me.txtEditAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditAddress.ForeColor = System.Drawing.Color.Black
        Me.txtEditAddress.Location = New System.Drawing.Point(33, 235)
        Me.txtEditAddress.Name = "txtEditAddress"
        Me.txtEditAddress.Size = New System.Drawing.Size(235, 21)
        Me.txtEditAddress.TabIndex = 58
        '
        'txtEditName
        '
        Me.txtEditName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditName.ForeColor = System.Drawing.Color.Black
        Me.txtEditName.Location = New System.Drawing.Point(33, 143)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(235, 21)
        Me.txtEditName.TabIndex = 57
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Firebrick
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.Location = New System.Drawing.Point(169, 316)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(146, 30)
        Me.btnEdit.TabIndex = 49
        Me.btnEdit.Text = "Save Changes"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'dialogStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 365)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.panelAdd)
        Me.Controls.Add(Me.panelEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dialogStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formAddBooks"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelAdd.ResumeLayout(False)
        Me.panelAdd.PerformLayout()
        CType(Me.StudentAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEdit.ResumeLayout(False)
        Me.panelEdit.PerformLayout()
        CType(Me.StudentEditAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelAdd As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents panelEdit As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtContact As TextBox
    Friend WithEvents StudentAvatar As PictureBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEditContact As TextBox
    Friend WithEvents StudentEditAvatar As PictureBox
    Friend WithEvents txtEditAddress As TextBox
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblEditID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
