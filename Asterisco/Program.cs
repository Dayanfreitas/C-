using System;

namespace Asterisco
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo(10,1);
            Console.WriteLine();
            triangulo(10,2);
            triangulo(10,3);
            
        }
        public static void triangulo(int numLinhas,int op)
        {
            int numDeAsterisco;
            if(op == 1)
            {
                for(int i=1;i<=numLinhas;i++)
                {
                    for(numDeAsterisco=0;numDeAsterisco < i;numDeAsterisco++)
                    {
                        Console.Write("*");
                    }
                Console.WriteLine();
                numDeAsterisco=0;
                }
            }
            //Do maior para menor
            else if(op == 2 )
            {
                for(int i=0;i<=numLinhas;i++)
                {
                    for(numDeAsterisco=numLinhas;numDeAsterisco > i;numDeAsterisco--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }    
        }
    }
}
