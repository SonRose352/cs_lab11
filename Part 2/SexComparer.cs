using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class SexComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x is null || y is null)
                throw new ArgumentException("Некорректное значение параметра");
            return (int)Char.GetNumericValue(x.Sex) - (int)Char.GetNumericValue(y.Sex);
        }
    }
}
