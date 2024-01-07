using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProcess
{
    public class Employee : Person
    {
        //Give the Employee class a property called ID and have it be of the data type int
        public int Id { get; set; }

        public void Emp(string firstName, string lastName)
        {
          Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
