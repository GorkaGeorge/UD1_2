Imports System

Module Program
    Sub Main(args As String())
        Console.Write(vbCrLf + "Cuál es tu nombre? ")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{vbCrLf}Hola, {name}, el día  {currentDate:d} a las  {currentDate:t}!")
        Console.Write(vbCrLf + "pulsa cualquier tecla para continuar")
        Console.ReadKey(True)
    End Sub
End Module
