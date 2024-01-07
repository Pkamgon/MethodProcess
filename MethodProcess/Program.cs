using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inside the Main method, instantiate and initialize an Employee object with
            //the first name "Sample" and last name "student"

            Employee employee = new Employee();
            string FirstName = "Sample";
            string LastName = "Student";
            employee.Emp(FirstName, LastName);
        }
    }
}
