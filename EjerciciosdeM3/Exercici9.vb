Public Class Exercici9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mes As Integer 
        Dim any As Integer
        Dim numerodias As Integer
        Dim numerodiasfebrero As String

        mes = CInt(TextBox1.Text)
        any = CInt(TextBox2.Text)

        If ((any Mod 4 = 0) And (any Mod 100 <> 0) Or (any Mod 400 = 0)) Then
            MessageBox.Show("El año " + Trim(any) + " es bisiesto")
        Else
            MessageBox.Show("El año " + Trim(any) + " no es bisiesto")
        End If

        If (mes = 1) Or (mes = 3) Or (mes = 5) Or (mes = 7) Or (mes = 8) Or (mes = 10) Or (mes = 12) Then
            MessageBox.Show("31 dias")
        ElseIf (mes = 4) Or (mes = 6) Or (mes = 9) Or (mes = 11) Then
            MessageBox.Show("30 dias")
        ElseIf (mes = 2) Then
            MessageBox.Show("Si es bisiesto tiene 29 dias si no, 28 dias")


        End If

    End Sub
End Class