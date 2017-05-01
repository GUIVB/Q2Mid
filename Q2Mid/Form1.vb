
Imports System.Math
Public Class Form1
    Private Sub FactBtn_Click(sender As Object, e As EventArgs) Handles FactBtn.Click
        Dim f = Val(factTB.Text)
        Dim r = 1


        For i = 1 To f

            r *= i


        Next

        FacR.Text = CStr(r)

    End Sub

    Private Sub PowBtn_Click(sender As Object, e As EventArgs) Handles PowBtn.Click
        Dim x = Val(XTb.Text)
        Dim y = Val(YTb.Text)

        PowerR.Text = CStr(Pow(x, y))



    End Sub
End Class
