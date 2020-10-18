Imports System

Module Program
    Public num1 As Integer
    Public num2 As Integer
    Public solucion As Integer
    Sub Main(args As String())
        Console.Write("Introduce el primer valor y pulsa Enter ")
        num1 = Console.ReadLine()
        Console.Write("Introduce el segundo valor y pulsa Enter ")
        num2 = Console.ReadLine()
        solucion = num1 + num2
        Console.WriteLine()
        Console.WriteLine("La solución es  " & solucion)
        Console.ReadLine()
    End Sub
End Module
