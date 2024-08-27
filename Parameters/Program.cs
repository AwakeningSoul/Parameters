using System;
using System.Collections.Generic;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee with type 'string'
            Employee<string> stringEmployee = new Employee<string>();
            // Assign a list of strings to the Things property
            stringEmployee.Things = new List<string> { "Alice", "Bob", "Charlie" };

            // Instantiate Employee with type 'int'
            Employee<int> intEmployee = new Employee<int>();
            // Assign a list of integers to the Things property
            intEmployee.Things = new List<int> { 1, 2, 3, 4, 5 };

            // Print all the things in the stringEmployee
            Console.WriteLine("String Employee Things:");
            foreach (var item in stringEmployee.Things)
            {
                Console.WriteLine(item);
            }

            // Print all the things in the intEmployee
            Console.WriteLine("\nInt Employee Things:");
            foreach (var item in intEmployee.Things)
            {
                Console.WriteLine(item);
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

