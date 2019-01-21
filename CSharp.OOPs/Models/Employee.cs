using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOPs.Models
{
    class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string dob;

        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        private int age;

        public int Age
        {
            get {
                age= DateTime.Now.Year - Convert.ToInt32(dob.Split('/')[2]);
                return age; }
        }



    }
}
