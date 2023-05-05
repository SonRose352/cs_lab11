using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3
{
    internal class MyPair<T, U>
    {
        private T First { get; set; }
        private U Second { get; set; }

        public MyPair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return (object)First;
                if (index == 1)
                    return (object)Second;
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index == 0)
                    First = (T)value;
                else if (index == 1)
                    Second = (U)value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
