using CSharp.OOPs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOPs
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee empname = new Employee();
            empname.Name = "Jojo";
            empname.DOB = "6/15/1990";            
            Console.WriteLine("The name of the employee is {0} and he is {1} old", empname.Name,empname.Age);


            Console.ReadLine();
        }
}


}
