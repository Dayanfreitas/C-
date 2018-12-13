using System;

namespace Calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;
            int fim=10;
            int soma=0;
            while(x <= fim){
                soma += x++;
            }
            Console.WriteLine($"Soma:{soma}");
        }
    }
}
