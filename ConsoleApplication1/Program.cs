using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 256; i++)
            {
                var result = i.ToString();
                if (i % 3 == 0)
                {
                    result = "Fizz";
                }
                if (i % 13 == 0)
                {
                    if (result != i.ToString())
                    {
                        result += "Fezz";
                    }
                    else
                    {
                        result = "Fezz";
                    }
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
                    if (result.Contains("Fezz"))
                    {
                        result = "FezzBuzz";
                    }
                    else
                    {
                        
                        result = "Bong";
                    }
                }

                if (i % 17 == 0)
                    if (result != i.ToString()) 
                    {
                        int savedlength = (result.Length) / 4;
                        List<string> temp = new List<string>();
                        for (int j = 0; j < savedlength; j++)
                        {
                            temp.Add(result.Substring(j*4,4));
                        }

                        result = "";

                        for (int j = savedlength; j > 0 ; j--)
                        {
                            result += temp[j-1];
                        }
                    }


                Console.WriteLine(result);
            }
            
        }
    }
}