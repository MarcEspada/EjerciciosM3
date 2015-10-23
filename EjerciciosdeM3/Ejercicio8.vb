Public Class Ejercicio8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nota As Integer
        Dim acta As String
        Const SUSPES As String = "S"
        Const APROVAT As String = "A"
        Const NOTABLE As String = "N"
        Const EXCELENT As String = "E"
        Const MATRICULA As String = "M"

        nota = CInt(TextBox1.Text)

        If ((nota >= 0) And (nota <= 4)) Then
            acta = SUSPES
        ElseIf ((nota = 5) Or (nota = 6)) Then
            acta = APROVAT
        ElseIf ((nota = 7) Or (nota = 8)) Then
            acta = NOTABLE
        ElseIf (nota = 9) Then
            acta = EXCELENT
        ElseIf (nota = 10) Then
            acta = MATRICULA
        End If

        MessageBox.Show(acta)
    End Sub
End Class