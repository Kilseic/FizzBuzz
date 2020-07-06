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
                bool multofthree = false;
                if (i % 3 == 0)
                {
                    multofthree = true;
                    result = "Fizz";
                }
                if (i % 5 == 0)
                {
                    if (multofthree == true)
                    {
                        result += "Buzz";
                    }
                    else
                    {
                        result = "Buzz";
                    }
                }
                
                
                Console.WriteLine(result);
            }
            
        }
    }
}