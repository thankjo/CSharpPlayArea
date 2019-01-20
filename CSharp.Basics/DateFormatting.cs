using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Basics
{
    class DateFormatting
    {
        public static void DateFormats(string date)
        {
            Console.WriteLine("5. Converting mm/dd/yyyy to dd/mm/yyyy");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            string[] datepart = date.Split('/');
            if (datepart.Length == 3)
            {
                string day = datepart[1];
                string month = datepart[0];
                string year = datepart[2];
                DateTime newdatetime = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
                Console.Write("The Formatted Date is {0} with out time", newdatetime.ToString("dd/MM/yyyy"));
                Console.Write("The Formatted Date is {0} with time", newdatetime.ToString("dd/MM/yyyy HH:MM tt"));

            }
        }
    }
}
