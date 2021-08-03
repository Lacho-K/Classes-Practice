using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CatsNDogs
{
    class Dog: IComparable<Dog>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog(string name)
        {
            this.Name = name;
        }

        public int CompareTo([AllowNull] Dog other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
