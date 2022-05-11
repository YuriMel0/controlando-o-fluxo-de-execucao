using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            quartoExemplo();
        }

        static void primeiroExemplo()
        {
            int numero;
            Boolean condicao = true;

            while (condicao)
            {
                Console.WriteLine(@"Informe um númmero, 0 para sair: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    condicao = false;
                }
                Console.WriteLine($"O número digitado foi {numero}");
            }
        }

        static void segundoExemplo()
        {
            int numero;
            Boolean condicao = true;

            do
            {
                Console.WriteLine(@"Informe um númmero, 0 para sair: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    condicao = false;
                }
                Console.WriteLine($"O número digitado foi {numero}");
            } while (condicao);
        }

        static void terceiroExemplo()
        {
            int numero;

            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void quartoExemplo()
        {
            int[] lista = {1, 2, 3, 4, 5};
            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
