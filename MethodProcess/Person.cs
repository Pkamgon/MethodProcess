using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProcess
{
    //Create a class called Person
    //One called FirstName, the other LastName
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
            Console.ReadLine();

        }

    }
}
