using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krishnamurthy_number
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check");
            int n = Convert.ToInt32(Console.ReadLine());

            int temp = n;
            int km = 0;
            while (temp > 0)
            {
                int rem = temp % 10;

                km += Fact(rem);

                temp /= 10;
            }

            Console.WriteLine(km == n ? "It is Krishnamurthy number" : "It is not a Krishnamurthy number");
        }

        public static int Fact(int n)
        {
            int fact = 1;
            while (n > 0)
            {
                fact *= n;
                n--;
            }

            return fact;
        }
    }
}
