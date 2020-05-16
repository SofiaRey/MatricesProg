Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub cbxOperation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOperation.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblARes.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inputPrimeraMatriz.TextChanged

    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        'Valores de primera matriz
        Dim first(8) As String
        first = Split(inputPrimeraMatriz.Text, ",")
        Dim a1 As String = first(0)
        Dim b1 As String = first(1)
        Dim c1 As String = first(2)
        Dim d1 As String = first(3)
        Dim e1 As String = first(4)
        Dim f1 As String = first(5)
        Dim g1 As String = first(6)
        Dim h1 As String = first(7)
        Dim i1 As String = first(8)

        'Valores de segunda matriz
        Dim second(8) As String
        second = Split(inputSegundaMatriz.Text, ",")
        Dim a2 As String = second(0)
        Dim b2 As String = second(1)
        Dim c2 As String = second(2)
        Dim d2 As String = second(3)
        Dim e2 As String = second(4)
        Dim f2 As String = second(5)
        Dim g2 As String = second(6)
        Dim h2 As String = second(7)
        Dim i2 As String = second(8)

        If cbxOperation.Text = "+" Then
            lblARes.Text = Convert.ToInt32(a1) + a2
            lblBRes.Text = Convert.ToInt32(b1) + b2
            lblCRes.Text = Convert.ToInt32(c1) + c2
            lblDRes.Text = Convert.ToInt32(d1) + d2
            lblERes.Text = Convert.ToInt32(e1) + e2
            lblFRes.Text = Convert.ToInt32(f1) + f2
            lblGRes.Text = Convert.ToInt32(g1) + g2
            lblHRes.Text = Convert.ToInt32(h1) + h2
            lblIRes.Text = Convert.ToInt32(i1) + i2
        End If
        If cbxOperation.Text = "-" Then
            lblARes.Text = Convert.ToInt32(a1) - a2
            lblBRes.Text = Convert.ToInt32(b1) - b2
            lblCRes.Text = Convert.ToInt32(c1) - c2
            lblDRes.Text = Convert.ToInt32(d1) - d2
            lblERes.Text = Convert.ToInt32(e1) - e2
            lblFRes.Text = Convert.ToInt32(f1) - f2
            lblGRes.Text = Convert.ToInt32(g1) - g2
            lblHRes.Text = Convert.ToInt32(h1) - h2
            lblIRes.Text = Convert.ToInt32(i1) - i2
        End If
        If cbxOperation.Text = "x" Then

            lblARes.Text = Convert.ToInt32(a1) * a2 + Convert.ToInt32(b1) * d2 + Convert.ToInt32(c1) * g2
            lblBRes.Text = Convert.ToInt32(a1) * b2 + Convert.ToInt32(b1) * e2 + Convert.ToInt32(c1) * h2
            lblCRes.Text = Convert.ToInt32(a1) * c2 + Convert.ToInt32(b1) * f2 + Convert.ToInt32(c1) * i2
            lblDRes.Text = Convert.ToInt32(d1) * a2 + Convert.ToInt32(e1) * d2 + Convert.ToInt32(f1) * g2
            lblERes.Text = Convert.ToInt32(d1) * b2 + Convert.ToInt32(e1) * e2 + Convert.ToInt32(f1) * h2
            lblFRes.Text = Convert.ToInt32(d1) * c2 + Convert.ToInt32(e1) * f2 + Convert.ToInt32(f1) * i2
            lblGRes.Text = Convert.ToInt32(g1) * a2 + Convert.ToInt32(h1) * d2 + Convert.ToInt32(i1) * g2
            lblHRes.Text = Convert.ToInt32(g1) * b2 + Convert.ToInt32(h1) * e2 + Convert.ToInt32(i1) * h2
            lblIRes.Text = Convert.ToInt32(g1) * c2 + Convert.ToInt32(h1) * f2 + Convert.ToInt32(i1) * i2
        End If

    End Sub
End Class
