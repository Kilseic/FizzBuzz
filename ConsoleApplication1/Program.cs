using System;
using System.Security.AccessControl;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i;
            for (i = 1; i < 101; i++)
            {
                var result = i.ToString();
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        result = "FizzBuzz";
                    }
                    else
                    {
                        result = "Fizz";
                    }
                } 
                Console.WriteLine(result);
            }
            
        }
    }
}