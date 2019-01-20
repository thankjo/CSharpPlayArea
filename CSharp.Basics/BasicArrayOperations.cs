using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Basics
{
    class BasicArrayOperations
    {
        public static void NumberArray()
        {
            Console.WriteLine("1.This is a number array");
            Console.WriteLine("************************");
            int[] numbers = { 22, 7, 35, 12, 3, 10 };
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        public static void DoubleArray()
        {
            Console.WriteLine("2.This is a double array");
            Console.WriteLine("************************");
            double[] prices = { 23.5, 12.87, 35.08, 44, 38.2 };
            foreach (double item in prices)
            {
                Console.WriteLine(item);
            }
        }
        public static void DecimalArary()
        {
            Console.WriteLine("3.This is a decimal array");
            Console.WriteLine("*************************");
            decimal[] decinumbers = {12, 32,51, 2, 98 };
            foreach (decimal item in decinumbers)
            {
                Console.WriteLine(item);
            }
        }
        public static void StringArray()
        {
            Console.WriteLine("4.This is a string arary");
            Console.WriteLine("************************");
            string[] names = { "Appu", "Pappu", "Mikki", "Kitti", "Tintu" };
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }

       

    }
}
