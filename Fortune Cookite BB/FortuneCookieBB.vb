'Brandon Barrera
'Spring 2025
'RCET2265
'FortuneCookie
'https://github.com/BrandLeBar/Fortune-Cookie-BB.git

Option Compare Text
Option Strict On
Option Explicit On
Module FortuneCookieBB

    Sub Main()
        Dim userInput As String

        While userInput <> "Q"

            Try

                Console.WriteLine("This your fortune...")

                Select Case RNGesus(1, 3)
                    Case 1
                        Console.WriteLine("If at first your voltages don't cancel out try, try again.")
                        Console.WriteLine()
                    Case 2
                        Console.WriteLine("You will find a low test score in your future.")
                        Console.WriteLine()
                    Case 3
                        Console.WriteLine("You will ask for another fortune, very soon.")
                        Console.WriteLine()
                End Select

            Catch ex As Exception

            End Try

            Console.WriteLine("Continue? Y/N")
            userInput = Console.ReadLine
            Console.WriteLine()

            If userInput = "N" Then
                Console.WriteLine("Bye Bye")
                Console.WriteLine()
                userInput = "Q"
            ElseIf userInput = "Y" Then
                Console.WriteLine("You are very fortunate, son.")
                Console.WriteLine()
            End If
        End While
    End Sub

    Function RNGesus(Min As Integer, Max As Integer) As Integer
        Randomize()
        Return CInt((Max - Min) * Rnd() + Min)
    End Function

End Module
