Imports System.IO

Public Class formMain

    Private records_query = "SELECT id, avatar, name, borrowed, contact, address FROM records"
    Private book_query = "SELECT id, title, publisher, date_published, author, copies FROM book"
    Private student_query = "SELECT id, avatar, name, contact, address, created_at FROM student"
    Private librarians_query = "SELECT id, avatar, name, contact, address, username, password, created_at FROM librarian"

    Private Sub formMain_Activated() Handles Me.Activated
        FillDataGridView(records_query, "avatar", dgvRecords)
        FillDataGridView(book_query, "", dgvBooks)
        FillDataGridView(book_query & " WHERE copies != 0", "", dgvBorrow)
        FillDataGridView(student_query, "avatar", dgvStudents)
        FillDataGridView(librarians_query & " WHERE id != 1", "avatar", dgvLibrarians)

        Dashboard()
        ClearDGVSelection()
    End Sub

    Private Sub NavBarButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDashboard.Click, btnRecords.Click, btnBooks.Click, btnBorrow.Click, btnStudents.Click, btnProfile.Click, btnLibrarians.Click, btnLogout.Click
        DefaultNavBarButtonColor()
        panels()

        If sender Is btnDashboard Then
            BreadCrumb("Dashboard")
            btnDashboard.BackColor = Color.Firebrick
            panelDashboard.Visible = True
            Dashboard()

        ElseIf sender Is btnRecords
            BreadCrumb("Records")
            btnRecords.BackColor = Color.Firebrick
            panelRecords.Visible = True
            panelReturnBtn.Visible = True

        ElseIf sender Is btnBooks
            BreadCrumb("Books")
            btnBooks.BackColor = Color.Firebrick
            panelBooks.Visible = True
            panelBooksBtn.Visible = True

        ElseIf sender Is btnBorrow
            BreadCrumb("Borrow")
            btnBorrow.BackColor = Color.Firebrick
            panelBorrow.Visible = True
            panelBorrowBtn.Visible = True
            dgvBorrowedBook.Rows.Clear()
            ClearBorrowDetails()

        ElseIf sender Is btnStudents
            BreadCrumb("Students")
            btnStudents.BackColor = Color.Firebrick
            panelStudents.Visible = True
            panelStudentsBtn.Visible = True

        ElseIf sender Is btnProfile
            BreadCrumb("Profile")
            btnProfile.BackColor = Color.Firebrick
            panelProfile.Visible = True
            Profile()

        ElseIf sender Is btnLibrarians
            BreadCrumb("Librarians")
            btnLibrarians.BackColor = Color.Firebrick
            panelLibrarians.Visible = True
            panelLibrariansBtn.Visible = True

        ElseIf sender Is btnLogout
            formLogin.Show()
            Me.Dispose()
        End If

        ClearTextSearch()
        ClearDGVSelection()

        ShowBtnAddBook(True)
        ShowBtnAddStudent(True)
        ShowBtnAddLibrarian(True)
    End Sub

    Private Sub BreadCrumb(ByVal breadcrumb)
        lblBreadCrumb.Text = breadcrumb
    End Sub

    Private Sub DefaultNavBarButtonColor()
        btnDashboard.BackColor = Color.DarkRed
        btnRecords.BackColor = Color.DarkRed
        btnBooks.BackColor = Color.DarkRed
        btnBorrow.BackColor = Color.DarkRed
        btnStudents.BackColor = Color.DarkRed
        btnProfile.BackColor = Color.DarkRed
        btnLibrarians.BackColor = Color.DarkRed
    End Sub
    Private Sub panels()
        panelDashboard.Visible = False
        panelRecords.Visible = False
        panelReturn.Visible = False
        panelReturnBtn.Visible = False
        panelBooks.Visible = False
        panelBooksBtn.Visible = False
        panelBorrow.Visible = False
        panelBorrowBtn.Visible = False
        panelStudents.Visible = False
        panelStudentsBtn.Visible = False
        panelProfile.Visible = False
        panelLibrarians.Visible = False
        panelLibrariansBtn.Visible = False
    End Sub

    Public Sub ShowBtnAddStudent(ByVal show As Boolean)
        If show = True Then
            btnAddStudent.Visible = True
            btnEditStudent.Visible = False
            btnDeleteStudent.Visible = False
            btnCancelStudent.Visible = False
        Else
            btnAddStudent.Visible = False
            btnEditStudent.Visible = True
            btnDeleteStudent.Visible = True
            btnCancelStudent.Visible = True
        End If
    End Sub

    Public Sub ShowBtnAddLibrarian(ByVal show As Boolean)
        If show = True Then
            btnAddLibrarian.Visible = True
            btnEditLibrarian.Visible = False
            btnDeleteLibrarian.Visible = False
            btnCancelLibrarian.Visible = False
        Else
            btnAddLibrarian.Visible = False
            btnEditLibrarian.Visible = True
            btnDeleteLibrarian.Visible = True
            btnCancelLibrarian.Visible = True
        End If
    End Sub

    Public Sub ShowBtnAddBook(ByVal show As Boolean)
        If show = True Then
            btnAddBook.Visible = True
            btnEditBook.Visible = False
            btnDeleteBook.Visible = False
            btnCancelBook.Visible = False
        Else
            btnAddBook.Visible = False
            btnEditBook.Visible = True
            btnDeleteBook.Visible = True
            btnCancelBook.Visible = True
        End If
    End Sub

    Public Sub ShowPanelReturn(ByVal show As Boolean)
        If show = True Then
            panelRecords.Visible = False
            panelReturn.Visible = True
            btnBack.Visible = True

        Else
            panelRecords.Visible = True
            panelReturn.Visible = False
            btnBack.Visible = False

        End If
    End Sub

    Private Sub ClearDGVSelection()
        dgvRecords.ClearSelection()
        dgvReturn.ClearSelection()
        dgvBooks.ClearSelection()
        dgvBorrow.ClearSelection()
        dgvBorrowedBook.ClearSelection()
        dgvStudents.ClearSelection()
        dgvLibrarians.ClearSelection()
    End Sub

    Public Sub ClearBorrowDetails()
        lblIDBorrower.Text = ""
        lblStudentIDReceipt.Text = ""
        txtNameBorrower.Clear()
        txtSearchStudentBorrow.Clear()
        lblNameReceipt.Text = "Name: "
        lblBorrowLeft.Text = "Borrow Left: "
        dgvBorrowedBook.Rows.Clear()
        StudentAvatarBorrower.Image = StudentAvatarBorrower.InitialImage
    End Sub

    Public Sub ClearTextSearch()
        txtSearchRecords.Clear()
        txtSearchBook.Clear()
        txtSearchStudent.Clear()
        txtSearchLibrarian.Clear()
    End Sub

    Private Sub btnBack_Click() Handles btnBack.Click
        ClearDGVSelection()
        ShowPanelReturn(False)
    End Sub

    Private Sub dgvRecords_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellDoubleClick
        ShowPanelReturn(True)

        Dim i = e.RowIndex
        If i <> -1 Then
            Dim bytes As Byte()
            With dgvRecords
                bytes = .Item("student_avatar_records", i).Value
                lblStudentID.Text = .Item("student_id_records", i).Value
                lblStudentName.Text = .Item("student_name_records", i).Value
                lblStudentContact.Text = .Item("student_contact_records", i).Value
                lblStudentAddress.Text = .Item("student_address_records", i).Value
            End With

            Dim ms As MemoryStream = New MemoryStream(bytes)
            StudentAvatar.Image = Image.FromStream(ms)
        End If

        Dim query = "SELECT id, title, author, publisher, date_published, date_borrowed FROM borrower WHERE student_id = " & lblStudentID.Text & " "
        FillDataGridView(query, "", dgvReturn)
        ClearDGVSelection()
    End Sub

    Private Sub dgvReturn_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReturn.CellDoubleClick
        Dim book_id = If(e.RowIndex <> -1, dgvReturn.Item(0, e.RowIndex).Value, Nothing)
        Dim query = "SELECT id, title, author, publisher, date_published, date_borrowed FROM borrower WHERE student_id = " & lblStudentID.Text & " "


        Dim message_box = MsgBox("Return this book?", MsgBoxStyle.YesNo, "Return Book")
        If message_box = DialogResult.Yes Then
            SQLProcess("DELETE FROM borrowed_details WHERE student_id = " & lblStudentID.Text & " AND book_id = " & book_id & " ")
            SQLProcess("UPDATE book SET copies=(copies + 1) WHERE id = " & book_id & " ")
            MsgBox("Book return successfully.", MsgBoxStyle.Information)
            FillDataGridView(query, "", dgvReturn)
        End If
    End Sub

    Private Sub dgvBorrow_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrow.CellDoubleClick, dgvBorrowedBook.CellDoubleClick
        Dim i = e.RowIndex, borrowed_left = 0, id = ""
        If i <> -1 Then
            id = txtSearchStudentBorrow.Text
            If txtSearchStudentBorrow.Text <> "" Then
                borrowed_left = (3 - FindData("SELECT borrowed FROM records WHERE id = " & id & " "))
            End If

            If sender Is dgvBorrow And dgvBorrowedBook.Rows.Count < borrowed_left Then
                Dim query, is_existed, selected_row

                selected_row = dgvBorrow.Rows(i).Cells("borrow_bookID").Value
                query = "SELECT book_id FROM borrowed_details WHERE book_id = " & selected_row & " AND student_id = " & id & " "

                is_existed = FindData(query)

                Dim exist As Boolean
                For Each row As DataGridViewRow In dgvBorrowedBook.Rows
                    If row.Cells(0).Value = selected_row Then
                        exist = True
                        Exit For
                    End If
                Next

                If exist Then
                    MsgBox("Book already listed.", MsgBoxStyle.Information)
                ElseIf selected_row = is_existed
                    MsgBox("Book already borrowed by this student.", MsgBoxStyle.Information)
                Else
                    With dgvBorrow
                        dgvBorrowedBook.Rows.Add(.Item("borrow_bookID", i).Value, .Item("borrow_bookTitle", i).Value)
                    End With
                End If

            ElseIf sender Is dgvBorrowedBook
                dgvBorrowedBook.Rows.RemoveAt(i)
            End If
        End If
    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        ShowBtnAddBook(False)

        Dim i = e.RowIndex
        If i <> -1 Then
            With dgvBooks
                dialogBook.lblEditID.Text = .Item("book_id", i).Value
                dialogBook.txtEditTitle.Text = .Item("book_title", i).Value
                dialogBook.txtEditAuthor.Text = .Item("book_author", i).Value
                dialogBook.txtEditPublisher.Text = .Item("book_publisher", i).Value
                dialogBook.txtEditDatePublished.Text = .Item("book_date_published", i).Value
                dialogBook.txtEditCopies.Text = .Item("book_copies", i).Value
            End With
        End If
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        ShowBtnAddStudent(False)

        Dim i = e.RowIndex
        If i <> -1 Then
            Dim bytes As Byte()
            With dgvStudents
                bytes = .Item("student_avatar", i).Value
                dialogStudent.lblEditID.Text = .Item("student_id", i).Value
                dialogStudent.txtEditName.Text = .Item("student_name", i).Value
                dialogStudent.txtEditContact.Text = .Item("student_contact", i).Value
                dialogStudent.txtEditAddress.Text = .Item("student_address", i).Value
            End With

            Dim ms As MemoryStream = New MemoryStream(bytes)
            dialogStudent.StudentEditAvatar.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub dgvLibrarians_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibrarians.CellClick
        ShowBtnAddLibrarian(False)

        Dim i = e.RowIndex
        If i <> -1 Then
            Dim bytes As Byte()
            With dgvLibrarians
                bytes = .Item("librarian_avatar", i).Value
                dialogLibrarian.lblEditID.Text = .Item("librarian_id", i).Value
                dialogLibrarian.txtEditName.Text = .Item("librarian_name", i).Value
                dialogLibrarian.txtEditContact.Text = .Item("librarian_contact", i).Value
                dialogLibrarian.txtEditAddress.Text = .Item("librarian_address", i).Value
                dialogLibrarian.txtEditUsername.Text = .Item("librarian_username", i).Value
                dialogLibrarian.txtEditPassword.Text = .Item("librarian_password", i).Value
            End With

            Dim ms As MemoryStream = New MemoryStream(bytes)
            dialogLibrarian.LibrarianEditAvatar.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click, btnEditStudent.Click, btnDeleteStudent.Click, btnCancelStudent.Click
        If sender Is btnAddStudent Then
            dialogStudent.ShowAddStudent()
        ElseIf sender Is btnEditStudent
            dialogStudent.ShowEditStudent()
        ElseIf sender Is btnDeleteStudent
            DeleteData("DELETE FROM student WHERE id = " & dialogStudent.lblEditID.Text & " ")
            FillDataGridView(student_query, "avatar", dgvStudents)
            ShowBtnAddStudent(True)
        ElseIf sender Is btnCancelStudent
            ShowBtnAddStudent(True)
        End If
        ClearDGVSelection()
    End Sub

    Private Sub btnLibrarian_Click(sender As Object, e As EventArgs) Handles btnAddLibrarian.Click, btnEditLibrarian.Click, btnDeleteLibrarian.Click, btnCancelLibrarian.Click
        If sender Is btnAddLibrarian Then
            dialogLibrarian.ShowAddLibrarian()
        ElseIf sender Is btnEditLibrarian
            dialogLibrarian.ShowEditLibrarian()
        ElseIf sender Is btnDeleteLibrarian
            DeleteData("DELETE FROM librarian WHERE id = " & dialogLibrarian.lblEditID.Text & " ")
            FillDataGridView(librarians_query, "avatar", dgvLibrarians)
            ShowBtnAddLibrarian(True)
        ElseIf sender Is btnCancelLibrarian
            ShowBtnAddLibrarian(True)
        End If
        ClearDGVSelection()
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click, btnEditBook.Click, btnDeleteBook.Click, btnCancelBook.Click
        If sender Is btnAddBook Then
            dialogBook.ShowAddBook()
        ElseIf sender Is btnEditBook
            dialogBook.ShowEditBook()
        ElseIf sender Is btnDeleteBook
            DeleteData("DELETE FROM book WHERE id = " & dialogBook.lblEditID.Text & " ")
            FillDataGridView(book_query, "", dgvBooks)
            ShowBtnAddBook(True)
        ElseIf sender Is btnCancelBook
            ShowBtnAddBook(True)
        End If
        ClearDGVSelection()
    End Sub

    Private Sub txtSearchRecords_TextChanged() Handles txtSearchRecords.TextChanged
        Dim query
        query = records_query & " WHERE CONCAT(id, name)"
        query += " LIKE '%" & txtSearchRecords.Text & "%'"

        FillDataGridView(query, "avatar", dgvRecords)
    End Sub

    Private Sub txtSearchStudentBorrow_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudentBorrow.TextChanged, txtSearchBookBorrow.TextChanged
        Dim count = 0, borrowed_left = 0
        Dim id = "", image_path = "", query = "SELECT * FROM student WHERE id = "

        id = txtSearchStudentBorrow.Text
        If txtSearchStudentBorrow.Text <> "" Then
            count = FindData("SELECT borrowed FROM records WHERE id = " & id & " ")
        End If
        borrowed_left = 3 - count

        If sender Is txtSearchStudentBorrow And id.Length = 6 Then
            If count < 3 Then
                'Display to borrower's info
                lblIDBorrower.Text = FindData(query & id, "id")
                txtNameBorrower.Text = FindData(query & id, "name")
                image_path = FindData(query & id, "avatar")

                lblBorrowLeft.Text = "Borrow Left: " & borrowed_left

                If Not image_path.Equals("") Then
                    StudentAvatarBorrower.Image = Image.FromFile(image_path)
                Else
                    lblIDBorrower.Text = "000000"
                    MsgBox("Student Not found!", MsgBoxStyle.Critical)
                End If

                'Display to borrowed book receipt
                lblStudentIDReceipt.Text = lblIDBorrower.Text
                lblNameReceipt.Text = txtNameBorrower.Text

                dgvBorrowedBook.Rows.Clear()
            Else
                lblIDBorrower.Text = "000000"
                MsgBox("Student has already borrowed three books.", MsgBoxStyle.Information)
            End If
        ElseIf sender Is txtSearchBookBorrow
            id = txtSearchBookBorrow.Text
            query = book_query & " WHERE CONCAT(id, title) LIKE '%" & id & "%' AND copies != 0"
            FillDataGridView(query, "", dgvBorrow)
        End If
    End Sub

    Private Sub txtSearchBook_TextChanged() Handles txtSearchBook.TextChanged
        Dim query = book_query & " WHERE CONCAT(id, title)"
        query += " LIKE '%" & txtSearchBook.Text & "%'"

        FillDataGridView(query, "", dgvBooks)
    End Sub

    Private Sub txtSearchStudent_TextChanged() Handles txtSearchStudent.TextChanged
        Dim query = student_query & " WHERE CONCAT(id, name)"
        query += " LIKE '%" & txtSearchStudent.Text & "%'"

        FillDataGridView(query, "avatar", dgvStudents)
    End Sub

    Private Sub txtSearchLibrarian_TextChanged(sender As Object, e As EventArgs) Handles txtSearchLibrarian.TextChanged
        Dim query = librarians_query & " WHERE id != 1 AND CONCAT(id, name)"
        query += " LIKE '%" & txtSearchLibrarian.Text & "%'"

        FillDataGridView(query, "avatar", dgvLibrarians)
    End Sub

    Private Sub btnBorrowBook_Click() Handles btnBorrowBook.Click
        Dim student_id = "", book_id = "", query, column_values(), values() As String
        student_id = lblStudentIDReceipt.Text

        If student_id <> "" And dgvBorrowedBook.RowCount > 0 Then
            For i = 0 To dgvBorrowedBook.Rows.Count - 1
                book_id = dgvBorrowedBook.Item(0, i).Value

                'Save borrowed book
                column_values = {"@student_id", "@book_id"}
                values = {student_id, book_id}

                query = "INSERT INTO borrowed_details values(@student_id, @book_id, Now(), null)"
                SQLProcess(query, column_values, values)

                'Subtract copies of book borrowed
                query = "UPDATE book Set copies=(copies - 1) WHERE id=@book_id"
                SQLProcess(query, column_values, values)

            Next
            MsgBox("Borrowed book successfully.", MsgBoxStyle.Information)
            ClearBorrowDetails()

        End If
    End Sub

    Private Sub txtSearchStudentBorrow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchStudentBorrow.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub Dashboard()
        lblRecords.Text = FindData("SELECT COUNT(id) FROM records")
        lblBooks.Text = FindData("SELECT COUNT(id) FROM book")
        lblStudents.Text = FindData("SELECT COUNT(id) FROM student")
        lblLibrarians.Text = FindData("SELECT (COUNT(id) - 1) FROM librarian")
    End Sub

    Public Sub Profile()
        Dim query, image_path
        query = "SELECT * FROM librarian WHERE id = " & formLogin.user_id & " "
        lblLibrarianID.Text = FindData(query, "id")
        lblLibrarianName.Text = FindData(query, "name")
        lblLibrarianContact.Text = FindData(query, "contact")
        lblLibrarianAddress.Text = FindData(query, "address")

        image_path = FindData(query, "avatar")
        LibrarianAvatar.Image = Image.FromFile(image_path)

        lblLibrarianUsername.Text = FindData(query, "username")
        lblLibrarianPassword.Text = FindData(query, "password")
    End Sub

    Dim Pos As Point
    Private Sub formMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub btnClose_Click() Handles btnClose.Click
        End
    End Sub
End Class