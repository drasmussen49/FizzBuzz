using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FizzBuzz myObj = new FizzBuzz();
            string myNum = myObj.Get(30);
            Console.WriteLine(myNum);*/
        }
    }
    public class FizzBuzz
    {
        public string Get(int num)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                return "FizzBuzz";
            }
            if (IsMultipleOf3(num))
            {
                return "Fizz";
            }
            if (IsMultipleOf5(num))
            {
                return "Buzz";
            }
            return num.ToString();
        }

        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }
        private bool IsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }
    }
}
