Public Class Ejercicio3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim orden As String = ""

        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
        n3 = CInt(TextBox3.Text)

        If (n1 < n2 And n2 < n3) Then
            orden = n3.ToString + "," + n1.ToString
        ElseIf (n1 < n3 And n3 < n2) Then
            orden = n2.ToString + "," + n1.ToString
        ElseIf (n2 > n1 And n1 > n3) Then
            orden = n2.ToString + "," + n3.ToString
        ElseIf (n2 > n3 And n3 > n1) Then
            orden = n2.ToString + "," + n1.ToString
        ElseIf (n3 > n2 And n2 > n1) Then
            orden = n3.ToString + "," + n1.ToString
        ElseIf (n3 > n1 And n1 > n2) Then
            orden = n3.ToString + "," + n2.ToString
        End If
        Label1.Text = orden
    End Sub
End Class