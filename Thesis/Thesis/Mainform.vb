Public Class Mainform

    Private currentForm As Form

    Private Sub InventoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem1.Click
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        Dim inventory As New frmInventory()
        inventory.TopLevel = False
        inventory.Dock = DockStyle.Fill
        pnlcontent.Controls.Add(inventory)
        inventory.Show()

        currentForm = inventory
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click

        Dim items As New frmitems()
        items.Show()

    End Sub
End Class