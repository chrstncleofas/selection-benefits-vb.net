Public Class Form1
    'to make it easy to codes declaration is the best way
    Dim phil, sss, gsis, pagibig, salary, contri, netpay, budget, allow, tax As Decimal

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        salary = Convert.ToDecimal(txtsalary.Text)

        If chkphil.Checked Then
            phil = (2 / 100) * salary
        End If
        If chkgsis.Checked Then
            gsis = (4 / 100) * salary
        End If
        If chksss.Checked Then
            sss = (3 / 100) * salary
        End If
        If chkpagibig.Checked Then
            pagibig = (3 / 100) * salary
        End If

        contri = phil + gsis + sss + pagibig

        tax = (15 / 100) * salary

        netpay = salary - contri - tax

        budget = (50 / 100) * salary

        allow = netpay - budget

        lblAllow.Text = Convert.ToDouble(allow)
        lblbudget.Text = Convert.ToDouble(budget)
        lblnetpay.Text = Convert.ToDouble(netpay)
        lblContri.Text = Convert.ToDouble(contri)
        lbltax.Text = Convert.ToDouble(tax)

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        txtsalary.Clear()
        ComboBox1.Text = ""
        lblContri.Text = ""
        lblnetpay.Text = ""
        lblbudget.Text = ""
        lblAllow.Text = ""
        chkphil.Checked = False
        chkgsis.Checked = False
        chksss.Checked = False
        chkpagibig.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MsgBox("Do you want to close this window", vbYesNo + vbQuestion, "Close") = vbYes Then
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub
End Class
