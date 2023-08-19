Public Class PayPal

    Private Sub PayPal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numtxt.Text = ePay.numtxt.Text
        idlbl.Text = ePay.idlbl.Text
        Try
            My.Computer.Network.Ping("www.google.com", 80)
            WebBrowser1.Navigate("https://chart.googleapis.com/chart?chs=300x300&cht=qr&chl=" + "https%3A//www.paypal.com/cgi-bin/webscr%3Fcmd%3D_xclick%26business%3D" + My.Settings.ppadd + "%26item_name%3D" + idlbl.Text + "%26amount%3D" + ePay.numtxt.Text)
            Timer1.Enabled = True
        Catch ex As Exception
            MsgBox("Try again.")
            Timer1.Interval = "1"
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Close()
    End Sub

    Private Sub bacbtn_Click(sender As Object, e As EventArgs) Handles bacbtn.Click
        Timer1.Enabled = False
        ePay.Show()
        Close()
    End Sub

End Class