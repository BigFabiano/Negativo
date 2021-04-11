using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n -- N E G A T I V O -- ");
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            
            if (numero < 0)
            {
                Console.WriteLine($"Você digitou um número negativo. {numero}");
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}
