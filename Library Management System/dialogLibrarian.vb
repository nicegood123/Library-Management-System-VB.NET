Imports System.Text.RegularExpressions

Public Class dialogLibrarian

    Private Sub dialogLibrarian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Set ID
        SetID("SELECT id FROM librarian", "id", lblID)
    End Sub

    Public Sub ShowAddLibrarian()
        panelAdd.Visible = True
        btnAdd.Visible = True
        panelEdit.Visible = False
        btnEdit.Visible = False
        ShowDialog()
    End Sub
    Public Sub ShowEditLibrarian()
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
        txtUsername.Clear()
        txtPassword.Clear()
        txtAddress.Clear()

        'Set default avatar image
        LibrarianAvatar.Image = LibrarianAvatar.InitialImage
    End Sub

    Private Sub btnAdd_Click() Handles btnAdd.Click
        If txtName.Text = "" Then
            MsgBox("Name field is required.", MsgBoxStyle.Exclamation)
            txtName.Focus()
        ElseIf txtUsername.Text = ""
            MsgBox("Username field is required.", MsgBoxStyle.Exclamation)
            txtUsername.Focus()
        ElseIf txtPassword.Text = ""
            MsgBox("Password field is required.", MsgBoxStyle.Exclamation)
            txtPassword.Focus()
        Else
            If isFound("SELECT username from librarian WHERE username = '" & txtUsername.Text & "' ") Then
                MsgBox("Username already taken.", MsgBoxStyle.Exclamation)
                txtUsername.Focus()
            Else
                Dim query, image_path, column_values(), values() As String

                'Save avatar
                image_path = "avatar\librarian\" & lblID.Text & ".jpg"
                SaveImage(image_path, LibrarianAvatar)

                'Save librarian info
                column_values = {"@id", "@avatar", "@name", "@address", "@contact", "@username", "@password"}
                values = {lblID.Text, image_path, txtName.Text, txtAddress.Text, txtContact.Text, txtUsername.Text, txtPassword.Text}

                query = "INSERT INTO librarian values(@id, @avatar, @name, @address, @contact, @username, @password, now(), now())"
                SQLProcess(query, column_values, values)

                'Set ID
                SetID("SELECT * FROM librarian", "id", lblID)
                Me.Close()
                MsgBox("Librarian successfully added.", MsgBoxStyle.Information)
                clear()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click() Handles btnEdit.Click
        If txtEditName.Text = "" Then
            MsgBox("Name field is required.", MsgBoxStyle.Exclamation)
            txtEditName.Focus()
        ElseIf txtEditUsername.Text = ""
            MsgBox("Username field is required.", MsgBoxStyle.Exclamation)
            txtEditUsername.Focus()
        ElseIf txtEditPassword.Text = ""
            MsgBox("Password field is required.", MsgBoxStyle.Exclamation)
            txtEditPassword.Focus()
        Else
            Dim query, image_path, column_values(), values() As String

            'Update avatar
            image_path = "avatar\librarian\" & lblEditID.Text & ".jpg"
            SaveImage(image_path, LibrarianEditAvatar)

            'Update librarian info
            column_values = {"@avatar", "@name", "@address", "@contact", "@username", "@password", "@id"}
            values = {image_path, txtEditName.Text, txtEditAddress.Text, txtEditContact.Text, txtEditUsername.Text, txtEditPassword.Text, lblEditID.Text}

            query = "UPDATE librarian SET avatar=@avatar, name=@name, address=@address, contact=@contact, username=@username, password=@password, updated_at=now() WHERE id=@id"
            SQLProcess(query, column_values, values)
            Me.Close()
            MsgBox("Librarian successfully updated.", MsgBoxStyle.Information)
            formMain.ShowBtnAddLibrarian(True)
        End If
    End Sub

    Private Sub LibrarianAvatar_Click(sender As Object, e As EventArgs) Handles LibrarianAvatar.Click
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            LibrarianAvatar.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub LibrarianEditAvatar_Click(sender As Object, e As EventArgs) Handles LibrarianEditAvatar.Click
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            LibrarianEditAvatar.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress, txtEditName.KeyPress
        If (Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso Not Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress, txtEditContact.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+" AndAlso Not Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress, txtEditUsername.KeyPress
        If (Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub btnClose_Click() Handles btnClose.Click, btnCancel.Click
        Me.Close()
        formMain.ShowBtnAddLibrarian(True)
    End Sub

End Class