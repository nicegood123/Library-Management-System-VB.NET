Public Class dialogStudent

    Private Sub dialogStudent_Activated() Handles Me.Activated
        'Set ID
        setID("SELECT id FROM student", "id", lblID)
    End Sub

    Public Sub ShowAddStudent()
        panelAdd.Visible = True
        btnAdd.Visible = True
        panelEdit.Visible = False
        btnEdit.Visible = False
        ShowDialog()
    End Sub
    Public Sub ShowEditStudent()
        panelEdit.Visible = True
        btnEdit.Visible = True
        panelAdd.Visible = False
        btnAdd.Visible = False
        ShowDialog()
    End Sub

    Private Sub clear()
        'clear textbox values
        txtName.Clear()
        txtContact.Clear()
        txtAddress.Clear()

        'Set default avatar image
        StudentAvatar.Image = StudentAvatar.InitialImage
    End Sub

    Private Sub btnAdd_Click() Handles btnAdd.Click
        If txtName.Text = "" Then
            MsgBox("Name field is required.", MsgBoxStyle.Exclamation)
            txtName.Focus()
        ElseIf txtContact.Text = ""
            MsgBox("Contact field is required.", MsgBoxStyle.Exclamation)
            txtContact.Focus()
        Else
            Dim query, image_path, column_values(), values() As String

            'Save avatar
            image_path = "avatar\students\" & lblID.Text & ".jpg"
            SaveImage(image_path, StudentAvatar)

            'Save student info
            column_values = {"@id", "@avatar", "@name", "@address", "@contact"}
            values = {lblID.Text, image_path, txtName.Text, txtAddress.Text, txtContact.Text}

            query = "INSERT INTO student values(@id, @avatar, @name, @address, @contact, now(), now())"
            SQLProcess(query, column_values, values)

            'Set ID
            SetID("SELECT * FROM student", "id", lblID)
            Me.Close()
            MsgBox("Student Successfully Added.", MsgBoxStyle.Information)
            clear()
        End If

    End Sub

    Private Sub btnEdit_Click() Handles btnEdit.Click
        If txtEditName.Text = "" Then
            MsgBox("Name field is required.", MsgBoxStyle.Exclamation)
            txtEditName.Focus()
        ElseIf txtEditContact.Text = ""
            MsgBox("Contact field is required.", MsgBoxStyle.Exclamation)
            txtEditContact.Focus()
        Else
            Dim query, image_path, column_values(), values() As String

            'Update avatar
            image_path = "avatar\students\" & lblEditID.Text & ".jpg"
            SaveImage(image_path, StudentEditAvatar)

            'Update student info
            column_values = {"@avatar", "@name", "@address", "@contact", "@id"}
            values = {image_path, txtEditName.Text, txtEditAddress.Text, txtEditContact.Text, lblEditID.Text}

            query = "UPDATE student SET avatar=@avatar, name=@name, address=@address, contact=@contact, updated_at=now() WHERE id=@id"
            SQLProcess(query, column_values, values)
            Me.Close()
            MsgBox("Student successfully updated.", MsgBoxStyle.Information)
            formMain.ShowBtnAddStudent(True)
        End If
    End Sub

    Private Sub StudentAvatar_Click() Handles StudentAvatar.Click
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            StudentAvatar.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub StudentEditAvatar_Click() Handles StudentEditAvatar.Click
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            StudentEditAvatar.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress, txtEditName.KeyPress
        If (Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso Not Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress, txtEditContact.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+" AndAlso Not Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub btnClose_Click() Handles btnClose.Click, btnCancel.Click
        Me.Close()
        formMain.ShowBtnAddStudent(True)
    End Sub
End Class