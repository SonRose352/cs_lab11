using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4
{
    internal class DoublyNode
    {
        //Поля
        public int Data { get; set; }
        public DoublyNode Previous { get; set; }
        public DoublyNode Next { get; set; }

        //Конструктор
        public DoublyNode(int data)
        {
            Data = data;
        }
    }
}
