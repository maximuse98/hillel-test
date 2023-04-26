public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Square(2));
        Console.WriteLine(Square(10));
    }

    public static int Square(int n)
    {
        return (int)Math.Pow(n, 2);
    }
}