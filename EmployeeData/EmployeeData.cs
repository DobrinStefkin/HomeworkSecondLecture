using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Gender (m / f): ");
        string gender = Console.ReadLine();
        Console.Write("Personal ID Number: ");
        long idNumber = long.Parse(Console.ReadLine());
        Console.Write("Unique employee number: ");
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Employee characteristics:");
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        if (gender == "m")
        {
            Console.WriteLine("Gender: Male");
        }
        else if (gender == "f")
        {
            Console.WriteLine("Gender: Female");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        Console.WriteLine("Personal ID Nymber: {0}", idNumber);
        if (uniqueEmployeeNumber < 27560000)
        {
            Console.WriteLine("Wrong Number");
        }
        else if (uniqueEmployeeNumber > 27569999)
        {
            Console.WriteLine("Wrong Number");
        }
        else
        {
            Console.WriteLine("Employee Unique Number: {0}", uniqueEmployeeNumber);
        }
    }
}