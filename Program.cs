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
    public static int Factorial(int number) 
    { 
       
        if (number< 0) 
        {
            throw new ArgumentException("The method works only with numbers greater than zero");
        }

        int result = 1;
        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            result *= currentNumber;
        }
        return result;
    }

    int factorial = Factorial(10);
    Console.WriteLine($"Factorial {number} ={factorial}")
}