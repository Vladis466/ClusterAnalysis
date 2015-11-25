Public Class Form1
    Dim pageController As Integer = 0


    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click


        Select Case pageController
            Case 0
                MessageBox.Show("You have found an Easter Egg! You cannot go backwards anymore silly!!")
            Case 1
                clustAnalys.Text = "Vlad's Cluster Analysis Solution"
                pageController = 0
                Label1.BringToFront()
            Case 2
                clustAnalys.Text = "The K-Means Method"
                pageController = 1
                KmethodLabel.BringToFront()
        End Select
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click


        Select Case pageController
            Case 0
                clustAnalys.Text = "The K-Means Method"
                pageController = 1
                KmethodLabel.BringToFront()
            Case 1
                clustAnalys.Text = "The K-Medoid Method"
                Label3KMediod.BringToFront()
                pageController = 2
            Case 2
                Me.Hide()
                Form2.Show()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads, bring first page to front and set it's page controller.
        Label1.BringToFront()
        pageController = 0

    End Sub

    Private Sub Label3KMediod_Click(sender As Object, e As EventArgs) Handles Label3KMediod.Click

    End Sub
End Class
