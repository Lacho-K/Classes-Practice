using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CatsNDogs
{
    class Cat : IComparable<Cat>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name)
        {
            this.Name = name;
        }

        public int CompareTo([AllowNull] Cat other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
