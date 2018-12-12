using System;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1=0,number2=0;

            Console.Write("Entre o primeiro número:");
            number1 = Int32.Parse( Console.ReadLine() );
            Console.Write("Entre o segundo número:");
            number2 = Int32.Parse( Console.ReadLine() );
            
          if(number1 == number2)
                Console.WriteLine(number1 + "==" + number2);
          if(number1 != number2)
                Console.WriteLine(number1 + "!=" + number2);
          if(number1 > number2)
                Console.WriteLine(number1 + ">" + number2);
          if(number1 < number2)
                Console.WriteLine(number1 + "<" + number2);
          if(number1 <= number2)
                Console.WriteLine(number1 + "<=" + number2);
          if(number1 >= number2)
                Console.WriteLine(number1 + ">=" + number2);
            
        }
    }
}
