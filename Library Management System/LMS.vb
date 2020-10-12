Imports System.IO
Imports MySql.Data.MySqlClient

Module LMS
    Private connection As MySqlConnection
    Private SQLCommand As MySqlCommand
    Private DataAdapter As MySqlDataAdapter
    Private DataTable As DataTable

    Public Sub setConnection(database)
        Try
            Dim db_connection = "server=localhost; user id=root; database="
            connection = New MySqlConnection(db_connection & database)
            connection.Open()

        Catch e As Exception
            ErrorMessage("Error 101: setConnection " & e.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub FillDataGridView(sql, column, datagridview)
        Try
            connection.Open()
            DataAdapter = New MySqlDataAdapter(sql, connection)
            DataTable = New DataTable
            DataAdapter.Fill(DataTable)

            If column <> "" Then
                DataTable.Columns.Add(column & "_path", GetType(Byte()))
                For Each grow As DataRow In DataTable.Rows
                    grow(column & "_path") = File.ReadAllBytes(CStr(grow(column)))
                Next
            End If
            datagridview.DataSource = DataTable

        Catch e As Exception
            ErrorMessage("Error 102: FillDataGridView " & e.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub SQLProcess(sql)
        Try
            connection.Open()
            SQLCommand = New MySqlCommand(sql, connection)
            With SQLCommand
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            ErrorMessage("Error 104: SQLProcess " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub
    Public Sub SQLProcess(sql, column_values(), values())
        Try
            connection.Open()
            SQLCommand = New MySqlCommand(sql, connection)

            With SQLCommand
                Dim i = 0
                For Each record In column_values
                    .Parameters.AddWithValue(column_values(i), values(i))
                    i += 1
                Next
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With

        Catch e As Exception
            ErrorMessage("Error 105: SQLProcess " & e.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub DeleteData(sql)
        Dim message_box, message
        message = "Are you sure you want to delete this data?"
        message_box = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If message_box = DialogResult.Yes Then
            SQLProcess(sql)
        End If
    End Sub

    Public Function FindData(sql)
        Dim value = 0
        Dim DataReader As MySqlDataReader

        Try
            connection.Open()
            SQLCommand = New MySqlCommand(sql, connection)

            DataReader = SQLCommand.ExecuteReader()

            If DataReader.Read() = True Then
                value = DataReader.GetValue(0)
            End If
            DataReader.Close()
        Catch ex As Exception
            ErrorMessage("Error 106: FindData " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return value
    End Function
    Public Function FindData(sql, column)
        Dim value = ""
        Dim DataReader As MySqlDataReader

        Try
            connection.Open()
            SQLCommand = New MySqlCommand(sql, connection)

            DataReader = SQLCommand.ExecuteReader()

            If DataReader.Read() Then
                value = DataReader.GetString(column)
            End If
            DataReader.Close()
        Catch ex As Exception
            ErrorMessage("Error 107: FindData " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return value
    End Function

    Public Function isFound(sql) As Boolean
        Dim found = False
        Dim DataReader As MySqlDataReader

        Try
            connection.Open()
            SQLCommand = New MySqlCommand(sql, connection)
            DataReader = SQLCommand.ExecuteReader()
            If DataReader.Read() Then
                found = True
            End If
            DataReader.Close()
        Catch ex As Exception
            ErrorMessage("Error 108: isFound " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return found
    End Function

    Public Sub SetID(sql, column, id)
        Try
            sql += " ORDER BY " & column & " DESC"
            connection.Open()
            DataAdapter = New MySqlDataAdapter(sql, connection)
            DataTable = New DataTable
            DataAdapter.Fill(DataTable)
            id.Text = DataTable.Rows(0).Item(column).ToString + 1
        Catch ex As Exception
            ErrorMessage("Error 104: setID " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub SaveImage(image_path, img)
        Dim bitmap As Bitmap = CType(img.Image, Bitmap)

        Dim image As New Bitmap(300, 300)
        Using g As Graphics = Graphics.FromImage(image)
            g.DrawImage(bitmap, 0, 0, image.Width + 1, image.Height + 1)
        End Using

        image.Save(image_path, Imaging.ImageFormat.Jpeg)
        image.Dispose()
    End Sub

    Public Sub ErrorMessage(message)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Module
