Module Module1

    Sub Main()
        Dim PlayerAChoice, PlayerBChoice As Integer
        Dim PLayerAscore As Integer = 0
        Dim PLayerBscore As Integer = 0
        Console.WriteLine("best of 5 goes..")
        Do
            Console.WriteLine("")
            Console.Write("Player A choose Rock(1),Paper(2) or Scissors(3):")
            PlayerAChoice = Console.ReadLine
            Console.Clear()
            Console.Write("Player B choose Scissors(1), Paper(2) or Rock(3)")
            PlayerBChoice = Console.ReadLine
            If (PlayerAChoice + PlayerBChoice) Mod 3 = 0 Then
                PLayerAscore += 1
                Console.Write("Player A Wins! ")
            ElseIf (PlayerAChoice + PlayerBChoice) Mod 3 = 2 Then
                PLayerBscore += 1
                Console.Write("Player B Wins! ")
            Else
                Console.Write("Draw ")
            End If
            Console.WriteLine(" The score Is A: " & PLayerAscore & " B:" & PLayerBscore)
        Loop Until PLayerAscore >= 5 Or PLayerBscore >= 5
        Console.WriteLine(" The score Is A: " & PLayerAscore & " B:" & PLayerBscore)
        Console.ReadLine()
    End Sub

End Module
