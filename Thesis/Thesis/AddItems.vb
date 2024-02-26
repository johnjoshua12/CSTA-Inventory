Public Class AddItems
    Private Sub AddItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCBO("SELECT * FROM brand", "brandID", "brand", cboxBrand)
        loadCBO("SELECT * FROM inv_remarks", "remarksID", "stats", cboxStatus)
        cboxBrand.SelectedIndex = -1
        cboxStatus.SelectedIndex = -1
    End Sub
    Private Function checker() As Boolean
        For Each obj As Object In pnlDE.Controls
            If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                If TypeOf obj Is TextBox Then
                    If Len(obj.Text) = 0 Then
                        checker = False
                        MsgBox("Insufficient Data", vbCritical, "Error")
                        obj.Focus()
                        Exit Function
                    End If
                ElseIf TypeOf obj Is ComboBox Then
                    If obj.SelectedIndex = -1 Then ' Assuming you want to check if a selection is made
                        checker = False
                        MsgBox("Insufficient Data", vbCritical, "Error")
                        obj.Focus()
                        Exit Function
                    End If
                End If
            End If
        Next
        checker = True
    End Function

    Private Sub cleaner()
        For Each obj As Object In pnlDE.Controls
            If TypeOf obj Is TextBox Then
                obj.Clear()
            ElseIf TypeOf obj Is ComboBox Then
                Dim comboBox As ComboBox = CType(obj, ComboBox)
                comboBox.SelectedIndex = -1
            End If
        Next
    End Sub
Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checker() = True Then
            Try
                Dim cmd As Odbc.OdbcCommand
                Dim sql As String
                Dim Inventory As frmInventory = CType(Application.OpenForms("frmInventory"), frmInventory)

                Call connect()

                If Val(frmInventory.dgv1.Tag) = 0 Then
                    sql = "INSERT INTO inventory (itemCode, brandID, SerialNo, expiration, qntty, isAvailable, remarksID, DOW) VALUES (?, ?, ?, ?, ?, 1, ?, ?)"
                    cmd = New Odbc.OdbcCommand(sql, con)
                    cmd.Parameters.AddWithValue("@itemInsert", Trim(txtItemCode.Text))
                    cmd.Parameters.AddWithValue("@brandInsert", Trim(cboxBrand.Text))
                    cmd.Parameters.AddWithValue("@SerialNoInsert", Trim(txtSerial.Text))
                    cmd.Parameters.AddWithValue("@expirationInsert", Trim(DTPexpdate.Text))
                    cmd.Parameters.AddWithValue("@qnttyInsert", Val(txtqntty.Text))
                    cmd.Parameters.AddWithValue("@remarksIDInsert", cboxStatus.SelectedItem.ToString()) ' Corrected
                    cmd.Parameters.AddWithValue("@DOWInsert", Trim(DTPDOW.Text))
                Else
                    ' UPDATE operation
                    sql = "UPDATE inventory SET itemCode=?, brandID=?, SerialNo=?, expiration=?, qntty=?, isAvailable=?, remarksID=? WHERE itemCode=?"
                    cmd = New Odbc.OdbcCommand(sql, con)
                    cmd.Parameters.AddWithValue("@itemIUpdate", Trim(txtItemCode.Text))
                    cmd.Parameters.AddWithValue("@brandUpdate", Trim(cboxBrand.Text))
                    cmd.Parameters.AddWithValue("@SerialNoUpdate", Trim(txtSerial.Text))
                    cmd.Parameters.AddWithValue("@expirationUpdate", Trim(DTPexpdate.Text))
                    cmd.Parameters.AddWithValue("@qnttyUpdate", Val(txtqntty.Text))
                    cmd.Parameters.AddWithValue("@isAvailableUpdate", 1) ' Assuming isAvailable always set to 1
                    cmd.Parameters.AddWithValue("@remarksIDUpdate", cboxStatus.SelectedItem.ToString()) ' Corrected
                    cmd.Parameters.AddWithValue("@DOWUpdate", Trim(DTPDOW.Text))
                    cmd.Parameters.AddWithValue("@itemCodeUpdate", Val(frmInventory.dgv1.Tag))
                End If

                cmd.ExecuteNonQuery()
                Call cleaner()
                Call LoadData("SELECT * FROM  vwinventory WHERE isAvailable", Inventory.dgv1)

                MsgBox("Record saved", vbInformation, "Save")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message.ToString, vbCritical, "Error")
            Finally
                GC.Collect()
                con.Close()
            End Try
        End If
    End Sub





    Public Sub loadRecord(ByVal id As Integer)
        Try
            Dim cmd As Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim dt As New DataTable
            Dim str As String = "select * from items where itemID=?"

            cmd = New Odbc.OdbcCommand(str, con)
            cmd.Parameters.AddWithValue("@", id)
            da.SelectCommand = cmd
            da.Fill(dt)
            txtItemCode.Text = dt.Rows(0)(1).ToString
            cboxBrand.Text = dt.Rows(0)(2).ToString
            txtqntty.Text = dt.Rows(0)(5).ToString
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
            GC.Collect()
        End Try
    End Sub

    Private Sub txtqntty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqntty.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtqntty_TextChanged(sender As Object, e As EventArgs) Handles txtqntty.TextChanged

    End Sub

End Class