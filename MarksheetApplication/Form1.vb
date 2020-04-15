Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, num4, num5, total, obtain, per, grade, p1, p2, p3, p4, p5 As Integer
        num1 = txtNetwork.Text
        num2 = txtJava.Text
        num3 = txtProject.Text
        num4 = txtSeminar.Text
        num5 = txtViva.Text

        total = 100 + 100 + 100 + 100 + 100
        lblTotalMarks.Text = total


    End Sub
End Class
