public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Root(225));
        Console.WriteLine(Square(10));
        Console.WriteLine(Fackt(5));
        
    }

    public static int Square(int n)
    {
        return n * n;
    }

    public static double Root(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException();
        }

        return Math.Sqrt(n);
    }

    public static long Fackt(long n)
    {
        if (n <= 0)
            return 0;
        return n > 1 ? n * Fackt(n - 1) : 1;
    }
}