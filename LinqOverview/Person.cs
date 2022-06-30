using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverview
{
    internal class Person
    {
        public Person( string nombre, int edad)
        {
            this.Age = edad;
            this.Name = nombre;
        }

        public int Age { get; set; }
        public string Name { get; set; }

    }
}
