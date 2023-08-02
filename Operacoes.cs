using System;
using System.Collections.Generic;

class Operacoes
{
    public void RealizarAdicao(int num1)
    {
        List<int> numeros = new List<int>();
        numeros.Add(num1);

        Console.WriteLine("Digite outro valor (ou digite 'q' para calcular):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
                break;
            int num = int.Parse(input);
            numeros.Add(num);
        }

        int resultado = 0;
        foreach (int num in numeros)
        {
            resultado += num;
        }
        Console.WriteLine($"Seu resultado: {string.Join(" + ", numeros)} = {resultado}");
    }

    public void RealizarSubtracao(int num1)
    {
        Console.WriteLine("Digite um outro valor: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Seu resultado: {num1} - {num2} = {num1 - num2}");
    }

    public void RealizarMultiplicacao(int num1)
    {
        Console.WriteLine("Digite um outro valor: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Seu resultado: {num1} * {num3} = {num1 * num3}");
    }

    public void RealizarDivisao(int num1)
    {
        Console.WriteLine("Digite um outro valor: ");
        int num4 = int.Parse(Console.ReadLine());
        if (num4 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
        else
        {
            Console.WriteLine($"Seu resultado: {num1} / {num4} = {num1 / num4}");
        }
    }
}