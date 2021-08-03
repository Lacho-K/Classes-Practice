using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator
    {
        public int Compare(Book first, Book second)
        {
            int result = first.Title.CompareTo(second.Title);
            if (result == 0)
            {
                return first.Year.CompareTo(second.Year);
            }
            return result;
        }
    }
}
