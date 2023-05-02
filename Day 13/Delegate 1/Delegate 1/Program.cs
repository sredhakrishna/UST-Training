using System;
class Program
{
    static int calculateSum(int x, int y)
    {
        return x + y;
    }
    public delegate int myDelegate(int num1, int num2);

    static void Main()
    {
        myDelegate d = new myDelegate(calculateSum);
        int result = d(5, 6);
        Console.WriteLine(result);
    }
}
