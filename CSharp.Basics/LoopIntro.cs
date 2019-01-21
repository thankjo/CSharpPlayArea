using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Basics
{
    class LoopIntro
    {
        public static void ForLoops()
        {
            Console.WriteLine("For Loop");
            string[] names = { "Nikki", "Kukku", "Nannu", "Devu", "Pachu" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
           
        }

        public static void ForEachLoops()
        {
            Console.WriteLine("ForEach Loop");
            string[] names = { "Nikki", "Kukku", "Nannu", "Devu", "Pachu" };           

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        public static void WhileLoops()
        {
            Console.WriteLine("While Loop");
            string[] names = { "Nikki", "Kukku", "Nannu", "Devu", "Pachu" };

            int k = 0;
            while (k < names.Length)
            {
                Console.WriteLine(names[k]);
                k++;
            }

        }
    }
}
