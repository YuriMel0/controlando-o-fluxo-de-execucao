using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            primeiroExemplo();
        }

        static void primeiroExemplo()
        {
            int numero;
            int resposta;

            while (true)
            {
                Console.WriteLine("Informe um número: ");
                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Quer continuar? [1 - SIM ou 0 - NÂO]");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 0)
                {
                    break;
                }
            }

        }
    }
}
