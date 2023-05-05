using Part_4;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task 1
        DoublyLinkedList list = new DoublyLinkedList();
        Console.Write("Введите элементы листа: ");
        string elem = Console.ReadLine();
        list.AddTail(Convert.ToInt32(elem));
        elem = Console.ReadLine();
        list.AddTail(Convert.ToInt32(elem));
        elem = Console.ReadLine();
        while (elem != "")
        {
            if (Math.Abs(list.Head.Data - Convert.ToInt32(elem)) < Math.Abs(list.Tail.Data - Convert.ToInt32(elem)))
                list.AddHead(Convert.ToInt32(elem));
            else
                list.AddTail(Convert.ToInt32(elem));
            elem = Console.ReadLine();
        }
        Console.WriteLine(DoublyLinkedList.ToString(list));

        //Task 2
    }
}