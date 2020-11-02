using System;
namespace SavingsAccountTest
{
    public class SavingsAccount
    {
        private static double annualInterestRate = 0.04;
        private double savingsBalance;

        // public double SavAccount
        // {
        //     get { return savingBalance; }
        //     set { savingsBalance = value;}
        // }

        // public SavingAccount(double startingbalance)
        // {
        //  SavingsBalance = startingbalance;
        // }

        public double SavingsBalance
        {
            get { return savingsBalance; }
            set { savingsBalance = value + CalculateMonthlyInterest(value); }
        }

        public SavingsAccount(double savings)
        {
            SavingsBalance = savings;
        }
        public double CalculateMonthlyInterest(double value)
        {
            return value * (annualInterestRate / 12);
        }

        public static void ModifyInterestRate(double rate)
        {
            annualInterestRate = rate / 100;
        }

        public override string ToString()
        {
            return string.Format("Total on savings account is {0:C}", SavingsBalance);
        }    
    }
}