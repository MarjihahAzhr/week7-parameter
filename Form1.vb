Public Class Form1
    Private Sub S1()
        lbltext1.Text = "Annyeong"
    End Sub
    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        S1()
    End Sub

    Private Sub S2()
        Dim strText As String
        strText = tb1.Text
        lbltext2.Text = strText
    End Sub
    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        S2()
    End Sub

    Private Function S3()
        Return "Annyeong"
    End Function
    Private Sub btnSubmit3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lbltext3.Text = S3()
    End Sub

    Private Function S4()
        Dim strText2 As String
        strText2 = tb2.Text
        Return strText2
    End Function
    Private Sub btnSubmit4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lbltext4.Text = S4()
    End Sub
End Class