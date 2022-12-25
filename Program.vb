Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("Please enter your name: ")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}")

        Dim n1 As Integer
        Dim n2 As Integer
        Dim answer As Integer

        Console.Write("Type a number")
        n1 = Console.ReadLine()
        Console.WriteLine("Type a second number")
        n2 = Console.ReadLine()
        answer = n1 + n2
        Console.WriteLine("the answer is " & answer)

    End Sub
End Module
