Imports System.Console
Imports System.Threading.Thread
Module Program
    Dim length As Double
    Dim shape As Char
    Dim width As Double
    Dim UserName As String
    Dim Passcode As String
    Dim UsernameLogin As String
    Dim PasscodeLogin As String
    Dim ValidLogin As Boolean
    Dim base As Double
    Dim radius As Double
    Dim height As Double
    Dim random As New Random
    Dim TestingMode As New Boolean
    Dim UserAnswer As Double
    Dim score As Integer
    Dim UIChoice As Integer
    Dim IsPlaying As Boolean = True
    Dim IsAnswerCorrect As Boolean
    Dim AnswerOption As Integer

    Private Function rectanglearea(length, width)
        WriteLine("The length is " & length & " .")
        WriteLine("The width is " & width & " .  ")
        WriteLine("What is the area?")
        UserAnswer = ReadLine()
        If UserAnswer = length * width Then
            WriteLine("Correct! +2 points")
            score = score + 2
            WriteLine("You now have " & score & " points.")
        Else
            WriteLine("Incorrect. 0 points.")
            WriteLine("You now have " & score & " points")
        End If

        Return length * width
    End Function

    Private Function trianglearea(base, height)
        WriteLine("The base is: " & base & " .")
        WriteLine("The height is " & height & " .")
        WriteLine("What is the area?")
        UserAnswer = ReadLine()
        If UserAnswer = (base * height) / 2 Then
            WriteLine("Correct! +2 points")
            score = score + 2
            WriteLine("You now have " & score & " points")
        Else
            WriteLine("Incorrect. 0 points.")
            WriteLine("The answer was " & (base * height) / 2 & " .")
            WriteLine("You now have " & score & " points")
        End If
        Return (base / 2) * height
    End Function

    Private Function circlearea(radius)
        WriteLine("The radius is:" & radius & " .")
        WriteLine("What is the area?")
        UserAnswer = ReadLine()
        If UserAnswer = Math.PI * radius ^ 2 Then
            WriteLine("Correct! +2 points")
            score = score + 2
            WriteLine("You now have " & score & " points")
        Else
            WriteLine("Incorrect. 0 points.")
            WriteLine("The answer was " & (base * height) / 2 & " .")
            WriteLine("You now have " & score & " points")
        End If
        Return Math.PI * radius ^ 2
    End Function

    Private Function AnswerChecker(UserAnswer, ActualAnswer)
        WriteLine("Please select an option between 1 and 4:")
        AnswerOption = random.Next(1, 5)
        If AnswerOption = 1 Then
            WriteLine("1) " & ActualAnswer)
            WriteLine("2) " & ActualAnswer - random.Next(1, 101))
            WriteLine("3) " & ActualAnswer * random.Next(1, 11))
            WriteLine("4) " & ActualAnswer + random.Next(1, 101))
        ElseIf AnswerOption = 2 Then
            WriteLine("1) " & ActualAnswer - random.Next(1, 101))
            WriteLine("2) " & ActualAnswer)
            WriteLine("3) " & ActualAnswer * random.Next(1, 11))
            WriteLine("4) " & ActualAnswer + random.Next(1, 101))
        ElseIf AnswerOption = 3 Then
            WriteLine("1) " & ActualAnswer - random.Next(1, 101))
            WriteLine("2) " & ActualAnswer * random.Next(1, 11))
            WriteLine("3) " & ActualAnswer)
            WriteLine("4) " & ActualAnswer + random.Next(1, 101))
        ElseIf AnswerOption = 4 Then
            WriteLine("1) " & ActualAnswer - random.Next(1, 101))
            WriteLine("2) " & ActualAnswer * random.Next(1, 11))
            WriteLine("3) " & ActualAnswer + random.Next(1, 101))
            WriteLine("4) " & ActualAnswer)
        Else
            WriteLine("Couldn't generate answer options, please call our support department on 0345 6000 650")
        End If
        Return IsAnswerCorrect = True

    End Function
    Sub Main(args As String())

        score = 0
        WriteLine("Welcome to the Area Quiz")
        Sleep(1500)
        WriteLine("There are 3 different types of shapes: Squares, Rectangles, and Triangles.")
        WriteLine("")
        WriteLine("You will choose which shape you want to guess the area of.")
        Sleep(1500)
        WriteLine("")
        WriteLine("I will generate some random measurements,")
        Sleep(1500)
        WriteLine("")
        WriteLine("And you will try to guess the area!")
        WriteLine("")
        WriteLine("Welcome AreaTrainer!")
        WriteLine("You have been logged into the Area Trainer account as the login web server is down.")
        WriteLine("We have contacted Ryan from Banditcloud regarding the matter and he hasn't replied.")
        WriteLine("Some server hosts are bad, we've learned.")
        'WriteLine("Please choose what you would like to do:")
        'WriteLine("1. Register")
        'WriteLine("2. Login")
        'WriteLine("3. Exit")
        'UIChoice = ReadLine()
        ' WriteLine("Please enter your username:")
        'UsernameLogin = ReadLine()
        'WriteLine("Please enter your passcode:")
        'PasscodeLogin = ReadLine()
        'If UIChoice = 1 Then
        'WriteLine("Please enter a username.")
        'UsernameLogin = ReadLine()
        'WriteLine("Please enter a password.")
        'PasscodeLogin = ReadLine()


        'FileOpen(1, "Logins.txt", OpenMode.Append)
        'PrintLine(1, UsernameLogin)
        'PrintLine(1, PasscodeLogin)
        'FileClose(1)

        'End If
        'If UIChoice = 2 Then
        'WriteLine("Please enter user ID")
        'UsernameLogin = ReadLine()
        'WriteLine("Please enter password")
        'PasscodeLogin = ReadLine()

        'FileClose(2)
        'If ValidLogin = False Then WriteLine("Login unsuccessful.")
        'End If
        'UserName = False

        While IsPlaying = True

            length = random.Next(1, 50)
            width = random.Next(1, 50)
            base = random.Next(1, 50)
            height = random.Next(1, 50)
            radius = random.Next(1, 50)

            WriteLine("Please select shape:")
            WriteLine("Enter 'r' for a rectangle or square")
            WriteLine("Enter 't' for a triangle")
            WriteLine("Enter 'c' for a circle")

            shape = ReadLine().ToUpper

            If shape = "R" Then
                rectanglearea(length, width)

            ElseIf shape = "t" Then
            End If
        End While
    End Sub

End Module
