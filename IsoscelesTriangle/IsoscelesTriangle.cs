using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char Copyright = '\u00a9';
        string cr = " " + " " + " " + Copyright + " " + " " + " " + "\n" + "\n" + " " + " " + Copyright + " " + Copyright + " " + " " + "\n" + "\n" + " " + Copyright + " " + " " + " " + Copyright + " " + "\n" + "\n" + Copyright + " " + Copyright + " " + Copyright + " " + Copyright + "\n";
        Console.WriteLine(cr);

        int copyrightSymbol = 0x00a9;
        char symbol = (char)copyrightSymbol;
        Console.WriteLine("  {0}", symbol);
        Console.WriteLine(" {0}{0}{0}", symbol);
        Console.WriteLine("{0}{0}{0}{0}{0}", symbol);
    }
}
