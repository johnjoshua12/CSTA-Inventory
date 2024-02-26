Public Class frmLogin


    Private Sub frmSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtpw.Text = "admin" Then
            MsgBox("Log in Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            frmInventory.Show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtpw.PasswordChar = ControlChars.NullChar ' Show characters as plain text
        Else
            txtpw.PasswordChar = "*"c ' Hide characters
        End If
    End Sub
End Class
