using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber,
                    secondNumber;
            int number1,
                number2,
                sum;
            Console.Write("Entre com o primerio número:");
            firstNumber = Console.ReadLine();
            Console.Write("Entre com o segundo número:");
            secondNumber = Console.ReadLine();
            number1 = Int32.Parse(firstNumber);
            number2 = Int32.Parse(secondNumber);
            sum = number1 + number2;
            Console.Write($"{number1} + {number2} = {sum}");            
        }
    }
}
