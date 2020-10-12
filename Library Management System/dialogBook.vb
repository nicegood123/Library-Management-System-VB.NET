Public Class dialogBook

    Private Sub dialogBook_Activated() Handles Me.Activated
        'Set ID
        SetID("SELECT id FROM book", "id", lblID)

        If Len(Trim(txtEditDatePublished.Text)) = 0 Then
            txtEditDatePublished.Enabled = True
        Else
            txtEditDatePublished.Enabled = False
        End If
        clear()
    End Sub

    Public Sub ShowAddBook()
        panelAdd.Visible = True
        btnAdd.Visible = True
        panelEdit.Visible = False
        btnEdit.Visible = False
        ShowDialog()
    End Sub
    Public Sub ShowEditBook()
        panelEdit.Visible = True
        btnEdit.Visible = True
        panelAdd.Visible = False
        btnAdd.Visible = False
        ShowDialog()
    End Sub

    Private Sub clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtCopies.Clear()
        txtPublisher.Clear()
        txtDatePublished.SelectedItem = Nothing
    End Sub

    Private Sub btnAdd_Click() Handles btnAdd.Click
        If txtTitle.Text = "" Then
            MsgBox("Title field is required.", MsgBoxStyle.Exclamation)
            txtTitle.Focus()
        Else
            Dim query, column_values(), values() As String

            'Save book info
            column_values = {"@id", "@title", "@author", "@publisher", "@date_published", "copies"}
            values = {lblID.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, txtDatePublished.Text, txtCopies.Text}

            query = "INSERT INTO book values(@id, @title, @author, @publisher, @date_published, @copies, now(), now())"
            SQLProcess(query, column_values, values)

            'Set ID
            SetID("SELECT * FROM book", "id", lblID)
            Me.Close()
            MsgBox("Book successfully added.", MsgBoxStyle.Information)
            clear()
        End If
    End Sub

    Private Sub btnEdit_Click() Handles btnEdit.Click
        If txtEditTitle.Text = "" Then
            MsgBox("Title field is required.", MsgBoxStyle.Exclamation)
            txtEditTitle.Focus()
        Else
            Dim query, column_values(), values() As String

            'Update book info
            column_values = {"@title", "@author", "@publisher", "@date_published", "copies", "@id"}
            values = {txtEditTitle.Text, txtEditAuthor.Text, txtEditPublisher.Text, txtEditDatePublished.Text, txtEditCopies.Text, lblEditID.Text}

            query = "UPDATE book SET title=@title, author=@author, publisher=@publisher, date_published=@date_published, copies=@copies, updated_at=now() WHERE id=@id"
            SQLProcess(query, column_values, values)
            Me.Close()
            MsgBox("Book successfully updated.", MsgBoxStyle.Information)
            formMain.ShowBtnAddBook(True)
        End If
    End Sub

    Private Sub txtDatePublished_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatePublished.KeyPress, txtEditDatePublished.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtCopies_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCopies.KeyPress, txtEditCopies.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtPublisher_KeyUp() Handles txtPublisher.KeyUp
        If txtPublisher.Text <> "" Then
            txtDatePublished.Enabled = True
        Else
            txtDatePublished.Enabled = False
        End If
    End Sub

    Private Sub txtEditPublisher_KeyUp() Handles txtEditPublisher.KeyUp
        If txtEditPublisher.Text <> "" Then
            txtEditDatePublished.Enabled = True
        Else
            txtEditDatePublished.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click() Handles btnClose.Click, btnCancel.Click
        Me.Close()
        formMain.ShowBtnAddBook(True)
    End Sub

End Class