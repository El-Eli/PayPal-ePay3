Public Class ePay

    Private Sub paybtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paybtn.Click
        If numtxt.Text <> "" AndAlso My.Settings.ppadd.Contains("@") AndAlso My.Settings.ppadd.Contains(".") Then
            PayPal.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            paybtn.Enabled = False
            setbtn.Enabled = False
            abobtn.Enabled = False
        Else
            MsgBox("Try again.")
        End If
    End Sub

    Private Sub setbtn_Click(sender As Object, e As EventArgs) Handles setbtn.Click
        Settings.Show()
        Hide()
    End Sub

    Private Sub abobtn_Click(sender As Object, e As EventArgs) Handles abobtn.Click
        MsgBox("ePay 3.0.1. © Copyright 2016 EMG Future Technologies Inc. All trademarks and registered trademarks are the property of their respective owners.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "1"
        Else
            numtxt.Text += "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "2"
        Else
            numtxt.Text += "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "3"
        Else
            numtxt.Text += "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "4"
        Else
            numtxt.Text += "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "5"
        Else
            numtxt.Text += "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "6"
        Else
            numtxt.Text += "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "7"
        Else
            numtxt.Text += "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "8"
        Else
            numtxt.Text += "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "9"
        Else
            numtxt.Text += "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If numtxt.Enabled = True AndAlso numtxt.Text = "0" Then
            numtxt.Text = String.Empty
            numtxt.Text += "0"
        Else
            numtxt.Text += "0"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If numtxt.Enabled = True Then
            numtxt.Text += "."
            Button11.Enabled = False
        Else
            MsgBox("Press the clear button twice.")
            Button11.Enabled = False
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If numtxt.Text <> "0" Then
            numtxt.Enabled = True
            numtxt.Text = "0"
            idlbl.Text = "id"
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            paybtn.Enabled = True
            setbtn.Enabled = True
            abobtn.Enabled = True
            numtxt.Text = "0"
            idlbl.Text = "id"
        End If
    End Sub

    Private Sub exibtn_Click(sender As Object, e As EventArgs) Handles exibtn.Click
        Close()
    End Sub

    Private Sub ePay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Settings.buna.ToString
        If Label1.Text = "default" Then
            MsgBox("Go to settings.")
        Else
            numtxt.Focus()
        End If
    End Sub

    Private Sub numtxt_TextChanged(sender As Object, e As EventArgs) Handles numtxt.TextChanged
        Dim RandomClass As New Random()
        Dim RandomNumber1 As Integer
        RandomNumber1 = RandomClass.Next(111111111, 999999999)
        idlbl.Text = RandomNumber1
        Dim a1, b1, c1, d1, e1, f1, g1, h1, i1, j1 As String
        Dim text As String
        a1 = "0"
        b1 = "1"
        c1 = "2"
        d1 = "3"
        e1 = "4"
        f1 = "5"
        g1 = "6"
        h1 = "7"
        i1 = "8"
        j1 = "9"
        text = idlbl.Text
        text = Replace(text, a1, "T")
        text = Replace(text, b1, "W")
        text = Replace(text, c1, "L")
        text = Replace(text, d1, "J")
        text = Replace(text, e1, "A")
        text = Replace(text, f1, "E")
        text = Replace(text, g1, "O")
        text = Replace(text, h1, "G")
        text = Replace(text, i1, "H")
        text = Replace(text, j1, "I")
        idlbl.Text = Now.Year.ToString + text
    End Sub

End Class
