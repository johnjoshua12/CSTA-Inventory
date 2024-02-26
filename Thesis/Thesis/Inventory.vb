Public Class frmInventory
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim additems As New AddItems()
        additems.ShowDialog()
    End Sub
    ' Form load event to initially load data into DataGridView
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Call LoadData("SELECT * FROM vwinventory", dgv1)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call LoadData("SELECT * FROM thesis where itemCode like '%" & Trim(txtSearch.Text) & "%'", dgv1)
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String = "UPDATE inventory set isAvailable = 0 WHERE itemCode=?"
        If Val(dgv1.Tag) = 0 Then
            MsgBox("SELECT A RECORD YOU WANT TO DELETE", vbCritical)
        Else
            If MsgBox("Are you sure you to delete the record???", vbYesNo + vbQuestion, ) = vbYes Then
                Try
                    Call connect()
                    cmd = New Odbc.OdbcCommand(sql, con)
                    cmd.Parameters.AddWithValue("@", Val(dgv1.Tag))
                    cmd.ExecuteNonQuery()
                    Call LoadData("SELECT * FROM inventory WHERE isAvailable = 1", dgv1)
                    dgv1.Tag = 0
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    con.Close()
                    GC.Collect()
                End Try
            End If
        End If
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Try
            dgv1.Tag = dgv1.Item(0, e.RowIndex).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Dim colname As String = dgv1.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            MsgBox("Edit is Clicked", vbInformation, "Inventory!")
        ElseIf colname = "Delete" Then
            MsgBox("Delete is Clicked", vbInformation, "Inventory!")
        End If
    End Sub
End Class