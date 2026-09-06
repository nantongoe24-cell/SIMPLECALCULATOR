using System;

class SavingsCalculator
{
    static void Main(string[] args)
    {
       
        decimal principal;
        decimal interestRate;
        decimal duration;

        
        Console.Write("Enter the principal amount: ");
        string principalInput = Console.ReadLine();
        bool principalIsNumeric = decimal.TryParse(principalInput, out principal);

        Console.Write("Enter the duration (in years): ");
        string durationInput = Console.ReadLine();
        bool durationIsNumeric = decimal.TryParse(durationInput, out duration);

        
        if (!principalIsNumeric || principal <= 0)
        {
            Console.WriteLine("Error: Principal amount must be a valid, positive number.");
            return;
        }

        if (!durationIsNumeric || duration <= 0)
        {
            Console.WriteLine("Error: Duration must be a valid, positive number.");
            return;
        }

       
        switch (principal)
        {
            case < 1000:
                interestRate = 2;  
                break;
            case >= 1000 and < 10000:
                interestRate = 3;   
                break;
            case >= 10000 and < 50000:
                interestRate = 4;   
                break;
            default:
                interestRate = 5;  
                break;
        }

       
        decimal balance = principal;
        int years = (int)duration; 

        Console.WriteLine();
        Console.WriteLine("----- Savings Calculator Results -----");
        Console.WriteLine("Principal Amount:   " + principal.ToString("C"));
        Console.WriteLine("Assigned Rate:      " + interestRate + "% (based on principal tier)");
        Console.WriteLine("Duration (years):   " + duration);
        Console.WriteLine();
        Console.WriteLine("Year-by-Year Balance (Compound Interest):");

        for (int year = 1; year <= years; year++)
        {
            decimal yearlyInterest = balance * (interestRate / 100);
            balance = balance + yearlyInterest;

            Console.WriteLine("Year " + year + ": Interest = " + yearlyInterest.ToString("C")
                + ", Balance = " + balance.ToString("C"));
        }

       
        Console.WriteLine();
        Console.WriteLine("Final Balance after " + years + " year(s): " + balance.ToString("C"));
    }
}
