using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку(знаки препинания не используются): ");
            string startString = Console.ReadLine();
            startString = startString.Replace(" ", String.Empty);
            int R = startString.Length / 2;

            string half1 = startString.Substring(0, R).ToLower();
            string half2 = startString.Substring(R + startString.Length % 2, R).ToLower();
            string half2r = "";

            int length = half2.Length - 1;
            while (length >= 0)
            {
                half2r = half2r + half2[length];
                length--;
            }

            if (half1 == half2r)
            {
                Console.WriteLine("Строка полиндром!");
            }
            else
            {
                Console.WriteLine("Строка не полиндром!");
            }

            Console.ReadKey();
        }
    }
}
