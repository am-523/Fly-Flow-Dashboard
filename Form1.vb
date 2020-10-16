Public Class Form1
    Private Sub Guna2CircleButton7_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton7.Click
        If Not pn_seacrh.Visible Then
            Guna2Transition1.ShowSync(pn_seacrh)
        Else
            Guna2Transition1.HideSync(pn_seacrh)
        End If
    End Sub
End Class
