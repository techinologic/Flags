Public Class Form1

    Private Sub picCanada_Click(sender As Object, e As EventArgs) Handles picCanada.Click
        lblMessage.Text = "Canada"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picUsa_Click(sender As Object, e As EventArgs) Handles picUsa.Click
        lblMessage.Text = "United States"

    End Sub

    Private Sub picAustralia_Click(sender As Object, e As EventArgs) Handles picAustralia.Click
        lblMessage.Text = "Australia"

    End Sub

    Private Sub picGreece_Click(sender As Object, e As EventArgs) Handles picGreece.Click
        lblMessage.Text = "Greece"

    End Sub

    Private Sub picUk_Click(sender As Object, e As EventArgs) Handles picUk.Click
        lblMessage.Text = "United Kingdom"

    End Sub

    Private Sub picGermany_Click(sender As Object, e As EventArgs) Handles picGermany.Click
        lblMessage.Text = "Germany"

    End Sub
End Class
