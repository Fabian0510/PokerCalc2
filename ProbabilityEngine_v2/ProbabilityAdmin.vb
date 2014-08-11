Public Class ProbabilityAdmin
    Private fListOfRedCards As List(Of String)
    Private fListOfBlackCards As List(Of String)

    Public Function heartProbability() As Double
        'This looks at all the lists and adds all the strings with heart
        'the index 0 and uses this as the numerator; the total number of cards
        'being the denominator
        Dim number As Integer
        Dim totalCards As Integer
        number = 0
        totalCards = fListOfBlackCards.Count + fListOfRedCards.Count
        For index As Integer = 0 To fListOfRedCards.Count - 1 Step 1
            If fListOfRedCards.Item(index).Chars(0) = "♥" Then
                number = number + 1
            End If
        Next
        Return number / totalCards
    End Function
    Public Function diamondProbability() As Double
        'This looks at all the lists and adds all the strings with diamond
        'the index 0 and uses this as the numerator; the total number of cards
        'being the denominator
        Dim number As Integer
        Dim totalCards As Integer
        number = 0
        totalCards = fListOfBlackCards.Count + fListOfRedCards.Count
        For index As Integer = 0 To fListOfRedCards.Count - 1 Step 1
            If fListOfRedCards.Item(index).Chars(0) = "♦" Then
                number = number + 1
            End If
        Next
        Return number / totalCards
    End Function
    Public Function clubProbability() As Double
        'This looks at all the lists and adds all the strings with club
        'the index 0 and uses this as the numerator; the total number of cards
        'being the denominator
        Dim number As Integer
        Dim totalCards As Integer
        number = 0
        totalCards = fListOfBlackCards.Count + fListOfRedCards.Count
        For index As Integer = 0 To fListOfBlackCards.Count - 1 Step 1
            If fListOfBlackCards.Item(index).Chars(0) = "♣" Then
                number = number + 1
            End If
        Next
        Return number / totalCards
    End Function
    Public Function spadeProbability() As Double
        'This looks at all the lists and adds all the strings with club
        'the index 0 and uses this as the numerator; the total number of cards
        'being the denominator
        Dim number As Integer
        Dim totalCards As Integer
        number = 0
        totalCards = fListOfBlackCards.Count + fListOfRedCards.Count
        For index As Integer = 0 To fListOfBlackCards.Count - 1 Step 1
            If fListOfBlackCards.Item(index).Chars(0) = "♠" Then
                number = number + 1
            End If
        Next
        Return number / totalCards
    End Function


    Public ReadOnly Property redCards() As List(Of String)
        'returns the listofredcards field as a read only list
        Get
            Return fListOfRedCards
        End Get
    End Property
    Public ReadOnly Property blackCards() As List(Of String)
        'returns the list of black cards as a read only list
        Get
            Return fListOfBlackCards
        End Get
    End Property
    Public Sub New(ByVal numOfDecks As Integer)
        'populates the two lists of cards, iterating through it based on an argument numOfDecks
        fListOfRedCards = New List(Of String)
        fListOfBlackCards = New List(Of String)
        'Add black cards
        'Add spades
        For i As Integer = 1 To numOfDecks Step 1
            fListOfBlackCards.Add("♠A")
            For index As Integer = 2 To 10 Step 1
                fListOfBlackCards.Add("♠" + index.ToString)
            Next
            fListOfBlackCards.Add("♠J")
            fListOfBlackCards.Add("♠Q")
            fListOfBlackCards.Add("♠K")
            'Add clubs
            fListOfBlackCards.Add("♣A")
            For index As Integer = 2 To 10 Step 1
                fListOfBlackCards.Add("♣" + index.ToString)
            Next
            fListOfBlackCards.Add("♣J")
            fListOfBlackCards.Add("♣Q")
            fListOfBlackCards.Add("♣K")
            'Add red cards
            'Add hearts
            fListOfRedCards.Add("♥A")
            For index As Integer = 2 To 10 Step 1
                fListOfRedCards.Add("♥" + index.ToString)
            Next
            fListOfRedCards.Add("♥J")
            fListOfRedCards.Add("♥Q")
            fListOfRedCards.Add("♥K")
            'Add diamonds
            fListOfRedCards.Add("♦A")
            For index As Integer = 2 To 10 Step 1
                fListOfRedCards.Add("♦" + index.ToString)
            Next
            fListOfRedCards.Add("♦J")
            fListOfRedCards.Add("♦Q")
            fListOfRedCards.Add("♦K")
        Next
    End Sub

    Public Function whichSuit() As String
        'Returns a string declaring which suit is more likely to come next
        Dim probabilityDict As Dictionary(Of String, Double)
        Dim listIndex As Double
        listIndex = 0
        Dim result As String
        result = ""
        probabilityDict = New Dictionary(Of String, Double)
        probabilityDict.Add("spade", spadeProbability())
        probabilityDict.Add("diamond", diamondProbability())
        probabilityDict.Add("club", clubProbability())
        probabilityDict.Add("heart", heartProbability())
        For index As Integer = 0 To 3 Step 1
            If probabilityDict.Values(index) > listIndex Then
                listIndex = probabilityDict.Values(index)
                result = probabilityDict.Keys(index)
            End If
        Next
        Return "The next card will most likely be a " + result + "."
    End Function

    Public Sub removeRedCard(ByVal cardNum As String)
        'Removes a red card from the list of remaining cards
        fListOfRedCards.Remove(cardNum)
    End Sub
    Public Sub removeBlackCard(ByVal cardNum As String)
	'Removes a black card from the list of remaining cards
        fListOfBlackCards.Remove(cardNum)
    End Sub
End Class
