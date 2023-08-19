Public Class Settings

    Private Sub valbtn_Click(sender As Object, e As EventArgs) Handles valbtn.Click
        If ppadtxt.Text.Contains("@") AndAlso bunatxt.Text <> "business name" Then
            My.Settings.ppadd = ppadtxt.Text
            My.Settings.buna = bunatxt.Text
            My.Settings.Save()
            MsgBox("Click back to return to the main menu.")
            ePay.Label1.Text = My.Settings.buna
        Else
            MsgBox("Verify information.")
        End If
    End Sub

    Private Sub bacbtn_Click(sender As Object, e As EventArgs) Handles bacbtn.Click
        ePay.Show()
        Close()
    End Sub

End Class