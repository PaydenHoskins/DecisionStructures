'Payden Hoskins
'RECT2265
'Spring 2025
'DecisionStructures



Option Explicit On
Option Strict On


Module DecisionStructures

    Sub Main()
        Dim butterscotch As Integer

        'assign 5 to butterscotch
        butterscotch = 5

        'test Is butterscotch greater than 6
        'display the result on the console

        If butterscotch > 6 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 6).")
        End If

        If butterscotch > 3 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 3).")
        End If

        If butterscotch > 4 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 4).")
        End If

        'If on of the evaluated statments are true it will display and everything else will be skipped
        If butterscotch > 6 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 6).")
        ElseIf butterscotch > 3 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 3).")
        ElseIf butterscotch > 4 Then
            Console.WriteLine("Butterscotch Is Great! (butterscotch > 4).")
        End If
    End Sub

End Module
