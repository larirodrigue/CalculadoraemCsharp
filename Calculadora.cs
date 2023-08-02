using System;

class Calculadora
{
    static void Main(string[] args)
    {
        var Operacoes = new Operacoes();
        
        Console.WriteLine("Calculadora iniciada");

        while (true)
        {
            Console.WriteLine("Digite um valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("\t+ - Adição");
            Console.WriteLine("\t- - Subtração");
            Console.WriteLine("\t* - Multiplicação");
            Console.WriteLine("\t/ - Divisão");
            Console.WriteLine("Qual será a opção? ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "+":
                    Operacoes.RealizarAdicao(num1);
                    break;
                case "-":
                    Operacoes.RealizarSubtracao(num1);
                    break;
                case "*":
                    Operacoes.RealizarMultiplicacao(num1);
                    break;
                case "/":
                    Operacoes.RealizarDivisao(num1);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Deseja fazer outra operação? (S/N)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() != "s")
                break;
        }
    }
}