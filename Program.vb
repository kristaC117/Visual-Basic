Imports System
Imports System.Security.Cryptography.X509Certificates
'Program One - Hello World and Simple addition program. 
'This is my first Visual Basic Program on 12/22/2022.\
'Krista Selene Conley'

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("Please enter your name: ")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}")

        Dim num1 As Integer
        Dim num2 As Integer
        Dim answer As Integer

        Console.Write("Type a number: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Type a second number: ")
        num2 = Console.ReadLine()
        answer = num1 + num2
        Console.WriteLine("the answer is " & answer)
        Module1.inner(num1, num2)


    End Sub
End Module
