using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Basics
{
    class ConditionIntro
    {
        public static void IFConditions()
        {
            int a = 5;
            int b = 34;

            if (a < b)
            {
                Console.WriteLine("{0} is big ", b);
            }
            else
            {
                Console.WriteLine("{0} is big ", a);
            }

            string output = a < b ? String.Format("{0} is big ", b) : String.Format("{0} is big ", a);
            Console.WriteLine(output);
        }

        public static void TernaryConditionsWithStringValue()
        {
            int a = 5;
            int b = 34;

            if (a < b)
            {
                Console.WriteLine("{0} is big ", b);
            }
            else
            {
                Console.WriteLine("{0} is big ", a);
            }

            string output = a < b ? String.Format("{0} is big ", b) : String.Format("{0} is big ", a);
            Console.WriteLine(output);
        }

        public static void TernaryConditionsWithboolValue()
        {
            int a = 5;
            int b = 14;
            int output = a < b ? b : a;
            Console.WriteLine("{0} is big", output);
        }
    }
}
