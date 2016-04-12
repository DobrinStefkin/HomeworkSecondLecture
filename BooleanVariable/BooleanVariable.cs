using System;

class BooleanVariable
{
    static void Main()
    {
        int male = 1;
        int female = 2;
        bool isFemale = (male < female);
        Console.WriteLine("My gender is male: {0}", isFemale);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("What's your gender?");
        String answer = Console.ReadLine();

        if (answer == "Male")
        {
            bool gender = true;
            Console.WriteLine(gender);
        }
        else if (answer == "Female")
        {
            bool gender = false;
            Console.WriteLine(gender);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
