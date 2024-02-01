Public Class Form1
    'Define French number words
    Private frenchWords As String() = {"un", "deux", "trois", "quatre", "cinq"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set up the form for when it is being loaded in
        Me.Text = "French Numbers"
        'Center the form on the User's screen
        Me.StartPosition = FormStartPosition.CenterScreen

        Me.MaximizeBox = False
        Me.MinimizeBox = False

        'Calculate the width of the five buttons
        Dim buttonWidth As Integer = 70

        'Create labels for the instructions
        Dim labelQuestion As New Label()
        labelQuestion.Text = "Do you know the French words for the numbers 1 through 5?"
        labelQuestion.AutoSize = True
        'Set width to match the buttons
        labelQuestion.Width = 5 * buttonWidth
        'Center the text
        labelQuestion.TextAlign = ContentAlignment.MiddleCenter
        labelQuestion.Location = New Point((Me.ClientSize.Width - labelQuestion.Width) \ 2, 20)
        Me.Controls.Add(labelQuestion)

        Dim labelInstructions As New Label()
        labelInstructions.Text = "Click the buttons below to see them."
        labelInstructions.AutoSize = False
        'Set width to match the buttons
        labelInstructions.Width = 5 * buttonWidth
        'Center the text
        labelInstructions.TextAlign = ContentAlignment.MiddleCenter
        labelInstructions.Location = New Point((Me.ClientSize.Width - labelQuestion.Width) \ 2, 50)
        Me.Controls.Add(labelInstructions)

        'Create buttons for numbers 1 through 5 with associated gray backgrounds
        For i As Integer = 1 To 5
            Dim button As New Button()
            button.Text = i.ToString()
            'Sets the background for each of the associated five buttons to gray
            button.BackColor = Color.LightGray
            button.Location = New Point((Me.ClientSize.Width - 5 * 70) \ 2 + (i - 1) * 70, 100)
            AddHandler button.Click, AddressOf Button_Click
            Me.Controls.Add(button)
        Next

        'Create an exit button
        Dim exitButton As New Button()
        exitButton.Text = "Exit"
        exitButton.BackColor = Color.LightGray
        exitButton.Location = New Point((Me.ClientSize.Width - exitButton.Width) \ 2, 150)
        AddHandler exitButton.Click, AddressOf ExitButton_Click
        Me.Controls.Add(exitButton)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        'Event handler for when a number button is clicked
        Dim button As Button = DirectCast(sender, Button)
        'Adjust for 0-based index
        Dim number As Integer = Integer.Parse(button.Text) - 1

        'Create a label to display the French word in a green box
        Dim labelFrenchWord As New Label()
        labelFrenchWord.Text = frenchWords(number)
        'Sets the background for the associated french word to green
        labelFrenchWord.BackColor = Color.LightGreen
        labelFrenchWord.AutoSize = True
        labelFrenchWord.Location = New Point(button.Location.X, button.Location.Y + button.Height + 5)
        Me.Controls.Add(labelFrenchWord)
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs)
        'Event handler for the exit button
        Me.Close()
    End Sub
End Class
