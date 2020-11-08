'Doyle Shaw
'RCET0265
'Fall 2020
'Multiplication Table
'https://github.com/shawdoyl/Roll-of-the-Dice

Option Explicit On
Option Strict On

Module Module1 ' bad name - TJR
    Sub Main()
        Dim sumDice As Integer
        Static firstDice As Integer
        Static secondDice As Integer
        Dim diceArray(1, 12) As Integer

        For i = 1 To 1000
            Randomize()
            firstDice = CInt((5 * Rnd()) + 1)
            Randomize()
            secondDice = CInt((5 * Rnd()) + 1)

            sumDice = firstDice + secondDice
            diceArray(1, sumDice) += 1 ' use the index rather than storing a number that is the same as the index - TJR

        Next

        Console.WriteLine(CStr("Roll of the Dice").PadLeft(39))
        Console.WriteLine(StrDup(66, "-"))
        For i = 2 To 12
            Console.Write(CStr(i).PadRight(5) & "|") ' use the index rather than storing a number that is the same as the index - TJR
        Next
        Console.WriteLine(System.Environment.NewLine & StrDup(66, "-"))
        For j = 2 To 12
            Console.Write(CStr(diceArray(1, j)).PadRight(5) & "|")
        Next
        Console.WriteLine(System.Environment.NewLine & StrDup(66, "-"))
        Console.ReadLine()

    End Sub

End Module
