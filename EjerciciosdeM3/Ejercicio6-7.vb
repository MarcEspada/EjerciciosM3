Public Class Ejercicio6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim diasemana As Integer
        Dim muestra As String

        diasemana = CInt(TextBox1.Text)

        If diasemana = 1 Then
            muestra = "LUNES"
        ElseIf diasemana = 2 Then
            muestra = "MARTES"
        ElseIf diasemana = 3 Then
            muestra = "MIERCOLES"
        ElseIf diasemana = 4 Then
            muestra = "JUEVES"
        ElseIf diasemana = 5 Then
            muestra = "VIERNES"
        ElseIf diasemana = 6 Then
            muestra = "SABADO"
        ElseIf diasemana = 7 Then
            muestra = "DOMINGO"
        End If

        MessageBox.Show(muestra)
    End Sub
End Class