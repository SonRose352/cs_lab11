using cs_lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cs_lab11
{
    internal class Program
    {
        public static void Swap<T>(T[] massiv, int a, int b)
        {
            T z = massiv[a];
            massiv[a] = massiv[b];
            massiv[b] = z;
        }

        public static T[] Delete<T>(T[] massiv, int a)
        {
            int k = 0;
            T[] result = new T[massiv.Length - 1];
            for (int i = 0; i < result.Length; i++)
            {
                if (i == a)
                    k++;
                result[i] = massiv[i + k];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            Program.output(ints);
            double[] doubles = { 0.3, 7.34, 3, 2.5, -2, 6 };
            Program.output(doubles);
            string[] strings = {"one", "two", "three", "four", "five" };
            Program.output(strings);
            Person[] persons = { new Person(), new Person(), new Person() };
            Program.Swap(persons, 0, 1);
        }

        public static void output<T>(T[] massiv)
        {
            Console.Write("\nМассив до замены: ");
            foreach (T elem in massiv)
            {
                Console.Write(elem + " ");
            }
            Program.Swap(massiv, 0, 1);
            Console.WriteLine("\nМассив после замены: ");
            foreach (T elem in massiv)
            {
                Console.Write(elem + " ");
            }
        }
    }
}
