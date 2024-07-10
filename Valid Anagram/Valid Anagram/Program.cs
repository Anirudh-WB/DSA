using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();

            str1 = new string(str1.OrderBy(c => c).ToArray());
            str2 = new string(str2.OrderBy(c => c).ToArray());

            bool fl = true;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        fl = false;
                        break;
                    }
                }
            }
            else
            {
                fl = false;
            }

            Console.WriteLine(fl ? "It is Valid Anagram" : "It is not a Vslid Anagram");
        }
    }
}
