using System;

namespace MilhasPraKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhas, km;

            Console.WriteLine("Digite uma medida em milhas para ser transformada em Km.");
            milhas = Convert.ToDouble(Console.ReadLine()!);

            km = milhas * 1.609;
            Console.WriteLine($"{km:F2} km.");
        }
    }
}