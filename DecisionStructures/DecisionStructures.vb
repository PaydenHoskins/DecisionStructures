Option Explicit On
Option Strict On
'Payden Hoskins
'RECT2265
'Spring 2025
'DecisionStructures



Imports System.ComponentModel

Module DecisionStructures

    Sub Main()
        Dim butterScotch As Integer
        Dim userInput As String

        'assign 5 to butterscotch
        butterScotch = 5

        'test Is butterscotch greater than 6
        'display the result on the console

        If butterScotch > 6 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 6).")
        End If

        If butterScotch > 3 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 3).")
        End If

        If butterScotch > 4 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 4).")
        End If

        'If on of the evaluated statments are true it will display and everything else will be skipped
        If butterScotch > 6 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 6).")
        ElseIf butterScotch > 3 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 3).")
        ElseIf butterScotch > 4 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 4).")
        End If


        butterScotch -= 3
        'if none of the conditions are met display else
        If butterScotch > 6 Then
            Console.WriteLine($"{butterScotch} is a big number!")
        ElseIf butterScotch > 3 Then
            Console.WriteLine($"Sorry not tall enough..!")
        ElseIf butterScotch > 4 Then
            Console.WriteLine("who gives a ... nevermind.")
        Else
            Console.WriteLine($"Not sure what is going on...")
        End If

        Console.WriteLine("Please enter age.")
        userInput = Console.ReadLine()
        butterScotch = CInt(userInput)
        Select Case butterScotch
            Case 0 To 3
                Console.WriteLine("too young.")
            Case 4 To 10
                Console.WriteLine("Come back next year kid.")
            Case 11 To 64

            Case 65 To 99

            Case > 100

            Case Else

        End Select

    End Sub

End Module
