Public Class Form1
    Dim Banana As Fruit
    Dim Orange As Fruit
    Dim DragonFruit As Fruit
    Dim Fruits(3) As Fruit
    Dim Points As Integer
    Dim labels(3) As Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Banana = New Fruit("Banana", pbx_Banana.Image)
        Orange = New Fruit("Orange", pbx_Orange.Image)
        DragonFruit = New Fruit("Dragon Fruit", pbx_DragonFruit.Image)
        Fruits = {Banana, Orange, DragonFruit}
        labels = {lbl_Banana, lbl_Orange, lbl_DragonFruit}
        For i = 0 To Fruits.Length - 1
            labels(i).Text = Fruits(i).Name
        Next
    End Sub

    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click
        'Dim 
        'Points = 0
        'For i = 1 To Fruits.Length
        '    Compare(Fruits(i).Image, )
        'Next

    End Sub
    Function Compare(ByRef points As Integer, ByRef ImageCompare As Bitmap, ByRef AnswerImage As Bitmap) As Boolean
        If ImageCompare.Equals(AnswerImage) Then
            points = points + 1
            Return True
        Else
            Return False
        End If
    End Function
End Class
