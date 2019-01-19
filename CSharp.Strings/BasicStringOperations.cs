using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Strings
{
    class BasicStringOperations
    {
        public static void SplitWord()
        {
            Console.WriteLine("1.This is splitting the word");
            Console.WriteLine("**************************");
            string msg = "This is my first string application";
            string[] words = msg.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        public static void SplitSentence()
        {
            Console.WriteLine("2.This is splitting the sentence");
            Console.WriteLine("******************************");
            string intro = "Hello. I am thankjo.This is my first string application";
            string[] sentence = intro.Split('.');
            foreach (string sentences in sentence)
            {
                Console.WriteLine(sentences.Trim());
            }           
        }

        public static void SplitNames()
        {
            Console.WriteLine("3.This is splitting names");
            Console.WriteLine("***********************");
            foreach (string name in "jojo,smitha,anu,sanju".Split(','))
            {
                Console.WriteLine(name.ToUpper() + "\n");

            }
        }

        public static void Makesentence()
        {
            Console.WriteLine("This is making sentences from words");
            Console.WriteLine("***********************");
            string data = "Dora,London,12345";
            string[] values = data.Split(',');
            Console.WriteLine("Hello. I am "+values[0]+". I am from " + values[1]+". You can reach me @ " + values[2] + ".");
        }

        public static void PublishAddress()
        {
            string name = "Chacko Mash";
            string address = "Spadikam";
            string mob = "9009090";
            string output = String.Format("This is {0} from {1}. Reach me @ {2}", name, address, mob);
            Console.WriteLine(output);
            //Console.WriteLine("This is {0} from {1}. Reach me @ {3}", name, address, mob);
        }
    }
}
