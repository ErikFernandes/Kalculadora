Module Program
    Public num1 As Integer
    Public num2 As Integer
    Public parame As Integer
    Public comp As Boolean
    Public result As Decimal

    Sub Main(args As String())
        Console.Write("Digite o primeiro n�mero: ")
        num1 = Console.ReadLine()
        Console.Write($"Digite o segundo n�mero: ")
        num2 = Console.ReadLine()

        Console.WriteLine("Escolha a opera��o; ")
        Console.WriteLine("1 - Soma ")
        Console.WriteLine("2 - Subtra��o ")
        Console.WriteLine("3 - Multiplica��o ")
        Console.WriteLine("4 - Divis�o ")


        parame = Console.ReadLine()

        Do

            If parame = 1 Then
                result = num1 + num2
                Console.WriteLine("O resultado � " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            ElseIf parame = 2 Then
                result = num1 - num2
                Console.WriteLine("O resultado � " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            ElseIf parame = 3 Then
                result = num1 * num2
                Console.WriteLine("O resultado � " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            ElseIf parame = 4 Then
                result = num1 / num2
                Console.WriteLine("O resultado � " & result)
                Console.WriteLine("Pressione qualque tecla...")
                Console.ReadKey(True)
                End

            Else
                Console.WriteLine("Por favor, selecione uma op��o v�lida!")
                Console.WriteLine("Escolha a opera��o; ")
                Console.WriteLine("1 - Soma ")
                Console.WriteLine("2 - Subtra��o ")
                Console.WriteLine("3 - Multiplica��o ")
                Console.WriteLine("4 - Divis�o ")
                parame = Console.ReadLine()
            End If


        Loop






    End Sub








End Module