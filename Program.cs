public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Root(225));
        Console.WriteLine(Square(10));
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
    public static int Factorial (int number)
    {
        if(number == 1)
        {
            return 1;
        }       

        return number  * Factorial(number - 1);

    }
}   