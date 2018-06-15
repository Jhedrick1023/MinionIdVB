Module Module1

    Sub Main()
        Console.WriteLine("Minion ID Generator")
        Console.WriteLine("Enter any number")
        Dim inputAsNumber As Double
        Dim continuePar As Boolean = False
        Dim whole, checkIfWhole As Double
        Dim stringId As String
        Dim primeString As String = ""

        Do
            Dim input As String = Console.ReadLine()

            If Double.TryParse(input, inputAsNumber) = True Then
                Console.WriteLine("You entered a valid number: {0}", inputAsNumber)
                continuePar = True
            Else
                Console.WriteLine("You didn't enter a number! Please enter a valid number.")
            End If
        Loop While continuePar = False

        For i As Double = 2 To 1993
            whole = 0

            For j As Double = 2 To i - 1
                checkIfWhole = i / j

                If checkIfWhole Mod 1 = 0 Then
                    whole += 1
                End If
            Next

            If whole = 0 Then
                primeString = primeString & i
            End If
        Next

        Dim userInput As Integer = Convert.ToInt32(inputAsNumber)
        userInput -= 1
        stringId = primeString.Substring(userInput, 5)
        Console.WriteLine("Your ID number is: {0}", stringId)
        Console.ReadKey()
    End Sub
End Module