using System;

namespace Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número\tQuadrado\tCubo");
            for(int i=0; i <=10;i++){
                Console.WriteLine($"{i}\t{Math.Pow(i,2)}\t\t{Math.Pow(i,3)}");
            }
        }
    }
}
