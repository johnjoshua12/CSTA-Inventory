Public Class frmHome

    Private Sub btnEquip_Click(sender As Object, e As EventArgs) Handles btnEquip.Click
        Try

            ' Create an instance of the form you want to show
            Dim Management As New Management()

            ' Set the TopLevel property to False
            Management.TopLevel = False

            ' Set the Parent property to the Panel control
            Management.Parent = Panel2

            ' Optionally, set the Dock property to fill the panel
            Management.Dock = DockStyle.Fill

            ' Show the form
            Management.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString, vbCritical, "products")
        Finally
            GC.Collect()
        End Try
    End Sub

End Class