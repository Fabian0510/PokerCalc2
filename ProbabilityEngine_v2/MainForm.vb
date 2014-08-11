Public Class MainForm
    Public fProbabilityAdmin As ProbabilityAdmin
    Public Sub New()
        Dim hello As Integer
        Dim aDeckNoDialogBox As DeckNoDialogBox
        aDeckNoDialogBox = New DeckNoDialogBox
        If aDeckNoDialogBox.ShowDialog = DialogResult.OK Then
            hello = Convert.ToInt32(aDeckNoDialogBox.NumericUpDown1.Value)
        End If
        fProbabilityAdmin = New ProbabilityAdmin(hello)
        ' This call is required by the designer.
        InitializeComponent()
        RedListBox.ForeColor = Color.Red
        updateView()
        aDeckNoDialogBox.Dispose()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub updateView()
        RedListBox.Items.Clear()
        BlackListBox.Items.Clear()
        For Each thing As String In fProbabilityAdmin.blackCards
            BlackListBox.Items.Add(thing)
        Next
        For Each thing As String In fProbabilityAdmin.redCards
            RedListBox.Items.Add(thing)
        Next
        HeartStatTextBox.Text = fProbabilityAdmin.heartProbability.ToString
        DiamondStatBox.Text = fProbabilityAdmin.diamondProbability.ToString
        ClubStatBox.Text = fProbabilityAdmin.clubProbability.ToString
        SpadeStatBox.Text = fProbabilityAdmin.spadeProbability.ToString
        ProbabilityTextBox.Text = fProbabilityAdmin.whichSuit
    End Sub

    Private Sub removeRedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeRedButton.Click
        'Removes the selected index from the red card list, runs updateView()
        If RedListBox.SelectedIndex >= 0 Then
            fProbabilityAdmin.removeRedCard(RedListBox.SelectedItem.ToString)
            updateView()
        End If
    End Sub

    Private Sub removeBlackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeBlackButton.Click
        'Removes the selected index from the black card list, runs updateView()
        If BlackListBox.SelectedIndex >= 0 Then
            fProbabilityAdmin.removeBlackCard(BlackListBox.SelectedItem.ToString)
            updateView()
        End If
    End Sub
End Class
