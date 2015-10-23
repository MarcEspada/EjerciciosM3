Public Class Ejercicio5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nota As Integer
        Dim acta As String
        Const SUSPES As String = "S"
        Const APROVAT As String = "A"
        Const NOTABLE As String = "N"
        Const EXCELENT As String = "E"
        Const MATRICULA As String = "M"

        nota = CInt(TextBox1.Text)

        If 0 <= nota And nota < 5 Then
            acta = SUSPES
        ElseIf 5 <= nota And nota < 6.5 Then
            acta = APROVAT
        ElseIf 6.5 <= nota And nota < 8.5 Then
            acta = NOTABLE
        ElseIf 8.5 <= nota And nota < 9.75 Then
            acta = EXCELENT
        ElseIf 9.75 <= nota And nota <= 10 Then
            acta = MATRICULA
        End If

        MessageBox.Show(acta)

    End Sub

End Class
