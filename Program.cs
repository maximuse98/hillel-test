public static class Program
{
    public static void Main(string[] args)
    {

        //Console.WriteLine(Root(225));
        //Console.WriteLine(Square(10));
        Console.WriteLine(Factorial(6));
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
    public static int Factorial(int number)
    {
        if (number == 0)
            return 1;
        int result = 1;
        for (int i = 1; i <= number; i++) 
        {
            result *= i;
        }
        return result;
    }
}