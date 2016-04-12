using System;

class ExchangeVariableValues
{
    static void Main()
    {
        Console.WriteLine("a=5");
        Console.WriteLine("b=10");
        int a = 5;
        int b = 10;
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a= {0}", a);
        Console.WriteLine("b= {0}", b);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("c = 5");
        Console.WriteLine("d = 10");
        int c = 5;
        int d = 10;
        c = c + d;
        d = c - d;
        c = c - d;
        Console.WriteLine("c = {0}", c);
        Console.WriteLine("d = {0}", d);
    }
}
