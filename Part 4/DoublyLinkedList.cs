using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4
{
    internal class DoublyLinkedList : IEnumerable
    {
        //Поля
        private DoublyNode head;
        private DoublyNode tail;
        private int count;

        //Метод возвращающий количество элементов в листе
        public int Count { get { return count; } }

        //Геттеры
        public DoublyNode Head { get { return head; } }
        public DoublyNode Tail { get { return tail; } }

        //Метод для добавления элемента в начало списка
        public void AddHead(int data)
        {
            DoublyNode node = new DoublyNode(data);

            DoublyNode temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        //Метод для добавления элемента в конец списка
        public void AddTail(int data)
        {
            DoublyNode node = new DoublyNode(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        //Enumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            DoublyNode current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        //Метод ToString
        public static string ToString(DoublyLinkedList list)
        {
            string elems = "";
            foreach (var elem in list)
            {
                elems += elem.ToString() + " ";
            }
            return elems;
        }
    }
}
