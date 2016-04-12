using System;

class BankAccountData
{
    static void Main()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter middle name: ");
        string middleName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Bank name:");
        string bankName = Console.ReadLine();
        Console.Write("Enter IBAN: ");
        string iban = Console.ReadLine();
        Console.Write("Enter BIC code: ");
        string bic = Console.ReadLine();
        Console.Write("Enter your first Credit card number: ");
        long firstCardNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter your second Credit card number: ");
        long secondCardNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter your third Credit card number: ");
        long thirdCardNumber = long.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Bank Account Information:");
        Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("BIC: {0}", bic);
        Console.WriteLine("First Credit card number: {0}", firstCardNumber);
        Console.WriteLine("Second Credit card number: {0}", secondCardNumber);
        Console.WriteLine("Third Credit card number: {0}", thirdCardNumber);
    }
}
