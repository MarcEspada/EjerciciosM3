Public Class Ejercicio4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vocal As String = "aeiou"
        Dim consonante As String = "bcdfghjklmnpqrstvwxyz"
        Dim entrada As String

        entrada = TextBox1.Text

        If (InStr(vocal, entrada) <> 0) Then
            MessageBox.Show("Es una vocal")
        ElseIf (InStr(consonante, entrada) <> 0) Then
            MessageBox.Show("Es una consonante")
        Else
            MessageBox.Show("Error, no se admiten estos caracteres")
        End If


    End Sub
End Class