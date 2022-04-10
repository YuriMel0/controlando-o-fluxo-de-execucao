using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            primeiroExemplo();
            segundoExemplo();
        }
        static void primeiroExemplo()
        {
            int idade;

            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("você é maior de idade");
            }
            else
            {
                Console.WriteLine("você é menor de idade");
            }
        }

        static void segundoExemplo()
        {
            int mes;

            Console.WriteLine("Informe um número correspondente a um mês: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Desembro");
                    break;
                default:
                    Console.WriteLine("O número não corresponde a nenhum mês, tente novamente");
                    break;
            }
        }
    }
}
