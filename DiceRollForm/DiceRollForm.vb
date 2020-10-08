'Doyle Shaw
'RCET0265
'Fall 2020
'DiceRollForm
'https://github.com/shawdoyl/Roll-of-the-Dice.git

Option Strict On
Option Explicit On
Option Compare Binary

Public Class DiceRollForm


    'Button that rolls two dice and adds the results displaying number of each result.
    'Button that clears the listbox and rolls the two dice again and redisplays the results.
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click, RollToolStripMenuItem.Click, ReRollButton.Click, RerollToolStripMenuItem.Click
        Dim sumDice As Integer
        Static firstDice As Integer
        Static secondDice As Integer
        Dim tempValue$
        Dim tempCount$
        Dim diceArray(1, 12) As Integer

        TotalsListBox.Items.Clear()

        For i = 1 To 1000
            Randomize()
            firstDice = CInt((5 * Rnd()) + 1)
            Randomize()
            secondDice = CInt((5 * Rnd()) + 1)
            sumDice = firstDice + secondDice
            For j = 2 To 12
                diceArray(0, j) = j
            Next
            Select Case sumDice
                Case sumDice
                    diceArray(1, sumDice) += 1
            End Select
        Next
        For i = 2 To 12
            tempValue &= CStr(diceArray(0, i)).PadLeft(5) & "|"
            tempCount &= CStr(diceArray(1, i)).PadLeft(5) & "|"
        Next

        TotalsListBox.Items.Add(CStr("Roll of the Dice").PadLeft(39))
        TotalsListBox.Items.Add(StrDup(66, "*"))
        TotalsListBox.Items.Add(tempValue)
        TotalsListBox.Items.Add(StrDup(66, "*"))
        TotalsListBox.Items.Add(tempCount)
        TotalsListBox.Items.Add(StrDup(66, "*"))

        'Disables Roll button after first click and enables Reroll.
        RollButton.Enabled = False
        ReRollButton.Enabled = True
        ReRollButton.Select()
        RerollToolStripMenuItem.Enabled = True
        RollToolStripMenuItem.Enabled = False
    End Sub

    'Button that closes the program.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Button that clears the listbox, and resets the Roll and Reroll buttons.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        TotalsListBox.Items.Clear()
        RollButton.Enabled = True
        RollButton.Select()
        ReRollButton.Enabled = False
        RerollToolStripMenuItem.Enabled = False
        RollToolStripMenuItem.Enabled = True
    End Sub

    'Toolstrip menu to show some details of the program
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("DiceRoll program Beta Version 2.0.001" & vbNewLine _
               & "Doyle Shaw" & vbNewLine _
               & "Fall 2020" & vbNewLine _
               & "RCET0265" & vbNewLine _
               & "In association with Elmer Fudd Industries.")
    End Sub

End Class
