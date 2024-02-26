Module modcon
    Public con As New Odbc.OdbcConnection
    Public Sub connect()
        Try
            con = New Odbc.OdbcConnection("dsn=thesis")
            con.Open()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbCritical, "Error!")
        Finally
            GC.Collect()

        End Try
    End Sub
    Public Sub LoadData(ByVal sql As String,
                    ByVal dgv1 As DataGridView)
        Try
            connect()
            Dim da As Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            dgv1.DataSource = dt
            da.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbCritical, "Error!")
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub loadCBO(ByVal sql As String, ByVal id As String, ByVal display As String, ByVal cbox As ComboBox)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        Try
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            cbox.DataSource = dt
            cbox.ValueMember = id
            cbox.DisplayMember = display

        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbCritical, "error")
        End Try
    End Sub
   
End Module
