Module Module1

    Sub Main()
        Console.WriteLine("What do you want to convert?")
        Console.WriteLine("a.) Celcius to Fahrenheit")
        Console.WriteLine("b.) Fahrenheit to Celcius")
        Console.Write("Enter the letter: ")
        Dim input As String = Console.ReadLine()
        If (input = "a" Or input = "A") Then
            Console.Write("What is the value?: ")
            Dim inputCelcius As String = Console.ReadLine()
            Dim celcius As Double
            If Double.TryParse(inputCelcius, celcius) Then
                Dim fahrenheit As String = celcius * (9 / 5) + 32
                Console.WriteLine("The value in fahrenheit is: " + fahrenheit)
                Console.WriteLine()
                Main()
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
                Main()
            End If
        ElseIf (input = "b" Or input = "B") Then
            Console.Write("What is the value?: ")
            Dim inputFahrenheit As String = Console.ReadLine()
            Dim fahrenheit As Double
            If Double.TryParse(inputFahrenheit, fahrenheit) Then
                Dim celcius As String = (fahrenheit - 32) * (5 / 9)
                Console.WriteLine("The value in celcius is: " + celcius)
                Console.WriteLine()
                Main()
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
                Main()
            End If
        Else
            Console.WriteLine("Invalid Input")
            Console.WriteLine()
            Main()
        End If
        Console.ReadLine()
    End Sub

End Module
