using System;

class Calculadora
{
    static void Main(string[] args)
    {
        var Operacoes = new Operacoes();

        Console.WriteLine("Calculadora iniciada");

        while (true)
        {
            int num1;
            while (true)
            {
                Console.WriteLine("Digite um valor: ");
                if (int.TryParse(Console.ReadLine(), out num1))
                    break;
                else
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }

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
