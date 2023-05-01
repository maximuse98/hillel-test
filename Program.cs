public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Root(225));
        Console.WriteLine(Square(10));
        Console.WriteLine(Factorial(5));

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

    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative");

        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}