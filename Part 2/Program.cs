using Part_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person("Vova", "Vasilev", new DateTime(2004, 3, 12), 'm');
        Person person2 = new Person("Masha", "Petrova", new DateTime(2003, 7, 23), 'f');
        Console.WriteLine($"{person1.CompareTo(person2)}\n");

        Person[] peoples = {person1,
            person2,
            new Person("Sveta", "Ivanova", new DateTime(1995, 12, 7), 'f'),
            new Person("Timur", "Sarambaev", new DateTime(2004, 11, 23), 'm')};

        Array.Sort(peoples);
        Console.WriteLine("\nЭлементы массива после сортировки по именам:");
        foreach (Person people in peoples)
        {
            Console.WriteLine(people.ToString());
        }

        Console.WriteLine($"\nМаксимальный объект Person в массиве (по имени): {Person.maxPerson(peoples).ToString()}");

        Array.Sort(peoples, new AgeComparer());
        Console.WriteLine("\nЭлементы массива после сортировки по возрасту:");
        foreach (Person people in peoples)
        {
            Console.WriteLine(people.ToString());
        }

        Console.WriteLine($"\nМаксимальный объект Person в массиве (по возрасту): {Person.maxPerson(peoples, new AgeComparer()).ToString()}");

        Array.Sort(peoples, new SexComparer());
        Console.WriteLine("\nЭлементы массива после сортировки по полу:");
        foreach (Person people in peoples)
        {
            Console.WriteLine(people.ToString());
        }

        Console.WriteLine($"\nМаксимальный объект Person в массиве (по полу): {Person.maxPerson(peoples, new SexComparer()).ToString()}");
    }
}