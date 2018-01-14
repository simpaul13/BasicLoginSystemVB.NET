Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            Form2.Show()
            Me.Close()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class