Module Program
    Public num1 As Integer
    Public num2 As Integer
    Public parame As Integer
    Public comp As Boolean
    Public result As Decimal

    Sub Main(args As String())
        Console.Write("Digite o primeiro número: ")
        num1 = Console.ReadLine()
        Console.Write($"Digite o segundo número: ")
        num2 = Console.ReadLine()

        Console.WriteLine("Escolha a operação; ")
        Console.WriteLine("1 - Soma ")
        Console.WriteLine("2 - Subtração ")
        Console.WriteLine("3 - Multiplicação ")
        Console.WriteLine("4 - Divisão ")


        parame = Console.ReadLine()

        Do

            If parame = 1 Then
                result = num1 + num2
                Console.WriteLine("O resultado é " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            ElseIf parame = 2 Then
                result = num1 - num2
                Console.WriteLine("O resultado é " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            ElseIf parame = 3 Then
                result = num1 * num2
                Console.WriteLine("O resultado é " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            ElseIf parame = 4 Then
                result = num1 / num2
                Console.WriteLine("O resultado é " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            Else
                Console.WriteLine("Por favor, selecione uma opção válida!")
                Console.WriteLine("Escolha a operação; ")
                Console.WriteLine("1 - Soma ")
                Console.WriteLine("2 - Subtração ")
                Console.WriteLine("3 - Multiplicação ")
                Console.WriteLine("4 - Divisão ")
                parame = Console.ReadLine()
            End If


        Loop






    End Sub








End Module