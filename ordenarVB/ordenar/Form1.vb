Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim array(3) As Integer
        a = Convert.ToInt32(T1.Text)
        b = Convert.ToInt32(T2.Text)
        c = Convert.ToInt32(T3.Text)
        array(1) = a
        array(2) = b
        array(3) = c
        Dim i As Integer
        Dim j As Integer
        Dim aux As Integer
        i = 1
        j = 4
recorrido1:
        If i < 4 Then
            i = i + 1
        Else
            GoTo Fin
        End If
recorrido2:
        If j >= i Then
            j = j - 1
        Else
            GoTo recorrido1
        End If
        If array(j) < array(j - 1) Then
            aux = array(j)
            array(j) = array(j - 1)
            array(j - 1) = aux
        End If

        GoTo recorrido2
Fin:
        Label2.Text = array(1).ToString() + " " + array(2).ToString() + " " + array(3).ToString()

    End Sub
End Class
