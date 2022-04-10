using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor;
            int segundoValor;
            int resultadoSoma;

            Console.WriteLine("Informe o primeiro valor: ");
            primeiroValor = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            segundoValor = int.Parse(Console.ReadLine());

            Console.WriteLine($"O primeiro valor digitado foi {primeiroValor}");
            Console.WriteLine($"O segudno valor digitado foi {segundoValor}");

            resultadoSoma = primeiroValor + segundoValor;
            Console.WriteLine($"O resultado da soma entre os valores é: {resultadoSoma}");
        }
    }
}
