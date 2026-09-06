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

       
        decimal simpleInterest = principal * (interestRate / 100) * duration;

        
        decimal finalBalance = principal + simpleInterest;

     
        Console.WriteLine();
        Console.WriteLine("----- Best Savings Calculator Results -----");
        Console.WriteLine("Principal Amount:   " + principal.ToString("C"));
        Console.WriteLine("Interest Rate:      " + interestRate + "%");
        Console.WriteLine("Duration (years):   " + duration);
        Console.WriteLine("Interest Earned:    " + simpleInterest.ToString("C"));
        Console.WriteLine("Final Balance:      " + finalBalance.ToString("C"));
    }
}
