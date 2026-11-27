using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora Básica ===");

        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("1 - Adição (+)");
        Console.WriteLine("2 - Subtração (-)");
        Console.WriteLine("3 - Multiplicação (*)");
        Console.WriteLine("4 - Divisão (/)");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        Console.WriteLine();

        switch (opcao)
        {
            case "1":
            case "+":
                Console.WriteLine($"Resultado: {Adicao(num1, num2)}");
                break;

            case "2":
            case "-":
                Console.WriteLine($"Resultado: {Subtracao(num1, num2)}");
                break;

            case "3":
            case "*":
                Console.WriteLine($"Resultado: {Multiplicacao(num1, num2)}");
                break;

            case "4":
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {Divisao(num1, num2)}");
                }
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    // Sub-rotinas obrigatórias
    static double Adicao(double a, double b)
    {
        return a + b;
    }

    static double Subtracao(double a, double b)
    {
        return a - b;
    }

    static double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    static double Divisao(double a, double b)
    {
        return a / b;
    }
}
