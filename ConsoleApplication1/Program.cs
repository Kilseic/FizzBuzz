using System;
using System.Security.AccessControl;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                var result = i.ToString();
                if (i % 3 == 0)
                {
                    result = "Fizz";
                }
                if (i % 5 == 0)
                {
                    if (result != i.ToString())
                    {
                        result += "Buzz";
                    }
                    else
                    {
                        result = "Buzz";
                    }
                }
                if (i % 7 == 0)
                {
                    if (result != i.ToString())
                    {
                        result += "Bang";
                    }
                    else
                    {
                        result = "Bang";
                    }
                }
                if (i % 11 == 0)
                {
                    result = "Bong";
                }

                if (i % 13 == 0)
                {
                    if (result != i.ToString())
                    {
                        result = "Fezz" + result;
                    }
                    else
                    {
                        result = "Fezz";
                    }
                }


                Console.WriteLine(result);
            }
            
        }
    }
}