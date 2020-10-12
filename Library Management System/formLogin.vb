Public Class formLogin

    Public user_id = ""

    Private Sub formLogin_Load() Handles MyBase.Load
        setConnection("lms")
    End Sub

    Private Sub btnLogin_Click() Handles btnLogin.Click
        Dim query = "SELECT id, username, password FROM librarian WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "' "
        user_id = FindData(query)

        If cboxAdmin.Checked Then
            query += " AND id = 1"
            formMain.btnLibrarians.Visible = True
            formMain.btnProfile.Visible = False
        ElseIf Not cboxAdmin.Checked Then
            query += " AND id != 1"
            formMain.btnLibrarians.Visible = False
            formMain.btnProfile.Visible = True
        End If

        If isFound(query) Then
            txtUsername.Clear()
            txtPassword.Clear()

            Me.Hide()
            formMain.Show()
        Else
            MsgBox("Username/password incorrect.", MsgBoxStyle.Critical)
        End If

    End Sub

    Dim Pos As Point
    Private Sub panelLoginTitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles panelLoginTitleBar.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click() Handles btnClose.Click
        End
    End Sub
End Class
