using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine();
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double b = double.Parse(Console.ReadLine());
        double esp = 0.000001;

        if (a - b > esp)
        {
            Console.WriteLine("false");
        }
        else if (b - a > esp)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}
