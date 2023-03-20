using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strEmployee = new Employee<string>();
            Employee<int> intEmployee = new Employee<int>();

            strEmployee.Things = new List<string>() { "Hello", "Goodbye", "Day", "Night" };

            intEmployee.Things = new List<int>() { 10, 25, 30, 45 };

            foreach (string word in strEmployee.Things)
            {
                Console.WriteLine(word);
            }

            foreach (int num in intEmployee.Things)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
