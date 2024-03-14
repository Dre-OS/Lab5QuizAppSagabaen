Imports System.Windows.Forms.VisualStyles

Public Class Form1
    Dim Banana As Fruit
    Dim Orange As Fruit
    Dim DragonFruit As Fruit
    Dim Fruits(3) As Fruit
    Dim AnswerPictureBoxes() As PictureBox
    Dim QuestionPictureBoxes() As PictureBox
    Dim Points As Integer
    Dim labels(3) As Label
    Dim down As Boolean
    Dim Swap As Boolean = False
    Dim Answer As Boolean
    Dim currentDrag As PictureBox
    Dim Temp As PictureBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbx_Question1.AllowDrop = True
        pbx_Question2.AllowDrop = True
        pbx_Question3.AllowDrop = True
        pbx_Trash.AllowDrop = True
        Banana = New Fruit("Banana", My.Resources.Banana)
        Orange = New Fruit("Orange", My.Resources.Orange)
        DragonFruit = New Fruit("Dragon Fruit", My.Resources.DragonFruit)
        Fruits = {Banana, Orange, DragonFruit}
        AnswerPictureBoxes = {pbx_Answer1, pbx_Answer2, pbx_Answer3}
        QuestionPictureBoxes = {pbx_Question1, pbx_Question2, pbx_Question3}
        labels = {lbl_Banana, lbl_DragonFruit, lbl_Orange}
        For i = 0 To Fruits.Length - 1
            labels(i).Text = Fruits(i).Name
            AnswerPictureBoxes(i).Image = Fruits(i).Image
        Next
    End Sub

    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click
        Points = 0
        For i = 0 To Fruits.Length - 1
            Compare(Points, QuestionPictureBoxes(i).Image, Fruits(i).Image)
        Next
        lbl_ScoreNum.Text = Points
        Select Case Points
            Case 0
                MessageBox.Show("Try Again Next Time!")
            Case 1
                MessageBox.Show("Good!")
            Case 2
                MessageBox.Show("Great!")
            Case 3
                MessageBox.Show("Excellent!!!")
        End Select
    End Sub
    Sub Compare(ByRef points As Integer, ByRef ImageCompare As Bitmap, ByRef AnswerImage As Bitmap)
        Try
            If ImageCompare IsNot Nothing And AnswerImage IsNot Nothing Then
                If ImageCompare.Equals(AnswerImage) Then
                    points = points + 1
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub pbx_Answers_MouseDown(sender As Object, e As MouseEventArgs) Handles pbx_Answer3.MouseDown, pbx_Answer2.MouseDown, pbx_Answer1.MouseDown
        Dim Pic As PictureBox = sender
        currentDrag = Pic
        Answer = True
        down = True
    End Sub

    Private Sub pbx_Answer_MouseMove(sender As Object, e As MouseEventArgs) Handles pbx_Answer3.MouseMove, pbx_Answer2.MouseMove, pbx_Answer1.MouseMove
        Dim Pic As PictureBox = sender
        If down And Pic.Image IsNot Nothing Then
            Pic.DoDragDrop(Pic.Image, DragDropEffects.Move)
        End If
        down = False
    End Sub

    Private Sub pbx_Question_DragDrop(sender As Object, e As DragEventArgs) Handles pbx_Question3.DragDrop, pbx_Question2.DragDrop, pbx_Question1.DragDrop
        'If Not Answer Then
        '    Return
        'End If
        Dim Pic As PictureBox = sender
        If Swap Then
            Dim CurrTemp As PictureBox = currentDrag
            Pic.Image = CurrTemp.Image
            currentDrag.Image = Temp.Image
            'Temp.Image = Pic.Image
            Swap = False
            Return
        Else
            currentDrag.Image = Nothing
        End If
        Pic.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub

    Private Sub pbx_Questions_MouseDown(sender As Object, e As MouseEventArgs) Handles pbx_Question3.MouseDown, pbx_Question2.MouseDown, pbx_Question1.MouseDown
        Dim Pic As PictureBox = sender
        currentDrag = Pic
        Answer = False
        Swap = True
        down = True
    End Sub

    Private Sub pbx_Questions_MouseMove(sender As Object, e As MouseEventArgs) Handles pbx_Question3.MouseMove, pbx_Question2.MouseMove, pbx_Question1.MouseMove
        Dim Pic As PictureBox = sender
        If down And Pic.Image IsNot Nothing Then
            Pic.DoDragDrop(Pic.Image, DragDropEffects.Move)
        End If

        down = False
    End Sub

    Private Sub pbx_Trash_DragDrop(sender As Object, e As DragEventArgs) Handles pbx_Trash.DragDrop
        If Not Answer Then
            currentDrag.Image = Nothing
        End If
    End Sub

    Private Sub pbx_All_DragEnter(sender As Object, e As DragEventArgs) Handles pbx_Trash.DragEnter, pbx_Answer3.DragEnter, pbx_Answer2.DragEnter, pbx_Answer1.DragEnter

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub pbx_Trash_Click(sender As Object, e As EventArgs) Handles pbx_Trash.Click
        For i = 0 To QuestionPictureBoxes.Length - 1
            QuestionPictureBoxes(i).Image = Nothing
        Next
        Points = 0
        lbl_ScoreNum.Text = Points
        For i = 0 To Fruits.Length - 1
            labels(i).Text = Fruits(i).Name
            AnswerPictureBoxes(i).Image = Fruits(i).Image
        Next
    End Sub

    Private Sub pbx_Trash_MouseEnter(sender As Object, e As EventArgs) Handles pbx_Trash.MouseEnter
        lbl_Reset.Visible = True
    End Sub

    Private Sub pbx_Trash_MouseLeave(sender As Object, e As EventArgs) Handles pbx_Trash.MouseLeave
        lbl_Reset.Visible = False
    End Sub

    Private Sub pbx_Question_DragEnter(sender As Object, e As DragEventArgs) Handles pbx_Question3.DragEnter, pbx_Question2.DragEnter, pbx_Question1.DragEnter
        Dim Pic As PictureBox = sender
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbx_Questions_DragOver(sender As Object, e As DragEventArgs) Handles pbx_Question3.DragOver, pbx_Question2.DragOver, pbx_Question1.DragOver
        Dim Pic As PictureBox = sender
        If Swap Then
            Temp = Pic
        End If
    End Sub
End Class
