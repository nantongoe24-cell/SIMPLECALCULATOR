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
        principal = Convert.ToDecimal(principalInput);

        Console.Write("Enter the annual interest rate (as a percentage, e.g. 5 for 5%): ");
        string rateInput = Console.ReadLine();
        interestRate = Convert.ToDecimal(rateInput);

        Console.Write("Enter the duration (in years): ");
        string durationInput = Console.ReadLine();
        duration = Convert.ToDecimal(durationInput);

      
        decimal balance = principal;
        int years = (int)duration; 

        Console.WriteLine();
        Console.WriteLine("----- Savings Calculator Results -----");
        Console.WriteLine("Principal Amount:   " + principal.ToString("C"));
        Console.WriteLine("Interest Rate:      " + interestRate + "%");
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
