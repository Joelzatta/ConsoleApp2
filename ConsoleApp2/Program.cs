using System;
using System.Windows;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;
            int resultado;

            Console.WriteLine("Digite um numero");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um numero para o contador");
            contador = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= contador; i++)
            {
                resultado = numero * i;

                Console.WriteLine($"{numero} x {i} = {resultado}");

            }
            Console.Read();
        }
    }
}
