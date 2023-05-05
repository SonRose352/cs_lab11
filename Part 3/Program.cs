using Part_3;

internal class Program
{
    private static void Main(string[] args)
    {
        MyPair<int, string> pair = new MyPair<int, string>(1, "one");
        Console.WriteLine(pair[0]);
        Console.WriteLine(pair[1]);
        pair[0] = 2;
        pair[1] = "two";
        Console.WriteLine(pair[0]);
        Console.WriteLine(pair[1]);
    }
}