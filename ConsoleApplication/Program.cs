using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Common;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowNumbers(5);
        }
        static List<int> ShowNumbers(INumberSequenceSource number)
        {
            int orderNumber = 0;
            List<int> list = null;
            int count = number.Count();
            for (int i = 0; i < count; i++)
            {
                list.Add(number);
            }
            Console.WriteLine($"{orderNumber}. elem: {list.ElementAt()}");
        }
    }
}
