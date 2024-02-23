using System;

namespace Workshop_Polymorphism
{
    public class Test
    {
        public static void Main()
        {
            bool withdraw;

            //Test Saving Account
            SavingAccount savingAccount = new SavingAccount("S0000333", "S3333333B", 2000);
            Console.WriteLine(savingAccount.ToString());
            Console.WriteLine("Interest: {0}", savingAccount.CalculateInterest());
            savingAccount.CreditInterest();
            Console.WriteLine(savingAccount.ToString());
            withdraw = savingAccount.Withdraw(3000);

            if (withdraw)
            {
                Console.WriteLine("Withdraw 3000 is ok.");
            }
            else
            {
                Console.WriteLine("Withdraw 3000 failed!");
            }

            Console.WriteLine();


            //Test Current Account
            CurrentAccount currentAccount = new CurrentAccount("S0000222", "S2222222B", 2000);
            Console.WriteLine(currentAccount.ToString());
            Console.WriteLine("Interest: {0}", currentAccount.CalculateInterest());
            currentAccount.CreditInterest();
            Console.WriteLine(currentAccount.ToString());
            withdraw = currentAccount.Withdraw(3000);

            if (withdraw)
            {
                Console.WriteLine("Withdraw 3000 is ok.");
            }
            else
            {
                Console.WriteLine("Withdraw 3000 failed!");
            }

            Console.WriteLine();

            //Test Overdraft account
            OverdraftAccount overdraftAccount1 = new OverdraftAccount("S0000222", "S2222222B", 2000);
            Console.WriteLine(overdraftAccount1.ToString());
            Console.WriteLine("Interest:{0}", overdraftAccount1.CalculateInterest());
            overdraftAccount1.CreditInterest();
            Console.WriteLine(overdraftAccount1.ToString());
            withdraw = overdraftAccount1.Withdraw(3000);

            if (withdraw)
            {
                Console.WriteLine("Withdraw 3000 is ok.");
            }
            else
            {
                Console.WriteLine("Withdraw 3000 failed!");
            }
            Console.WriteLine(overdraftAccount1.ToString());
            Console.WriteLine();

            OverdraftAccount overdraftAccount2 = new OverdraftAccount("S0000222", "S2222222B", -2000);
            Console.WriteLine(overdraftAccount2.ToString());
            Console.WriteLine("Interest: {0}", overdraftAccount2.CalculateInterest());
            overdraftAccount2.CreditInterest();
            Console.WriteLine(overdraftAccount2.ToString());
            Console.WriteLine();

            BankBranch bankbranch = new BankBranch("ISS Bank Branch");
            bankbranch.AddAccount(savingAccount);
            bankbranch.AddAccount(currentAccount);
            bankbranch.AddAccount(overdraftAccount1);
            bankbranch.AddAccount(overdraftAccount2);

            Console.WriteLine();
            Console.WriteLine("Print all accounts");
            bankbranch.PrintAccounts();

            Console.WriteLine();
            Console.WriteLine("Total deposit is: {0}", bankbranch.TotalDeposits());
            Console.WriteLine("Total interest paid is: {0}", bankbranch.TotalInterestPaid());
            Console.WriteLine("Total interest earned is: {0}", bankbranch.TotalInterestEarn());

            Console.WriteLine();
            Console.WriteLine("Print all customers");
            bankbranch.PrintCustomers();

            Console.ReadLine();
        }
    }
}

