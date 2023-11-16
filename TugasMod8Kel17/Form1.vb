Imports TempConv

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConv As New TempConv.TempConvComp
        Dim c As Double
        c = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.cToR(c)
        Label10.Text = "Reamur"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConv As New TempConv.TempConvComp
        Dim c As Double
        c = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.cToF(c)
        Label10.Text = "Fahrenheit"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objConv As New TempConv.TempConvComp
        Dim c As Double
        c = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.cToK(c)
        Label10.Text = "Kelvin"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objConv As New TempConv.TempConvComp
        Dim r As Double
        r = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.rToC(r)
        Label10.Text = "Celcius"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objConv As New TempConv.TempConvComp
        Dim r As Double
        r = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.rToF(r)
        Label10.Text = "Fahrenheit"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objConv As New TempConv.TempConvComp
        Dim r As Double
        r = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.rToK(r)
        Label10.Text = "Kelvin"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim objConv As New TempConv.TempConvComp
        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.fToc(f)
        Label10.Text = "Celcius"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim objConv As New TempConv.TempConvComp
        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.fToR(f)
        Label10.Text = "Reamur"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim objConv As New TempConv.TempConvComp
        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.fToK(f)
        Label10.Text = "Kelvin"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim objConv As New TempConv.TempConvComp
        Dim k As Double
        k = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.kToC(k)
        Label10.Text = "Celcius"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim objConv As New TempConv.TempConvComp
        Dim k As Double
        k = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.kToR(k)
        Label10.Text = "Reamur"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim objConv As New TempConv.TempConvComp
        Dim k As Double
        k = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.kToF(k)
        Label10.Text = "Fahrenheit"
    End Sub


End Class

