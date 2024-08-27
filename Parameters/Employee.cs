using System;
using System.Collections.Generic;

namespace Parameters
{
    // Define a generic Employee class
    public class Employee<T>
    {
        // Property to hold a list of the generic type T
        public List<T> Things { get; set; }

        // Constructor to initialize the Things property
        public Employee()
        {
            Things = new List<T>();
        }
    }
}

