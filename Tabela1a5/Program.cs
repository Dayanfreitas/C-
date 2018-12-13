using System;

namespace Tabela1a5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            Console.WriteLine("N\t10*N\t100*N\t1000*N");
            while(i<=5){
                Console.Write($"{i}\t{i*10}\t{i*100}\t{i*1000}\n");
                i++;
            }
        }
    }
}
