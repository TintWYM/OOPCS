using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Polymorphism
{
    public class Account
    {
        private string? acctHolderId;
        private double balance;
        public virtual double interest => 0;

        public Account() { }

        public Account(string acctNumber, string acctHolderId, double balance)
        {
            AccNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
        }

        public string AccNumber { get; }

        public string AccountHolderId { get => acctHolderId; set { acctHolderId = value; } }

        public double Balance { get => balance; set { balance = value; } }

        public void Deposit(double amt)
        {
            Balance += amt;
        }

        public virtual bool Withdraw(double amt)
        {
            if (balance >= amt && balance >= 0)
            {
                balance -= amt;
                return true;
            }
            return false;
        }

        public void TransferTo(Account receiver, double amt)
        {
            if (this.Withdraw(amt))
            {
                receiver.Deposit(amt);
            }
        }

        public override string ToString()
        {
            return "Acc No is: " + AccNumber + "Acc Holder ID is: " + AccountHolderId + "Balance is: " + Balance;
        }


        public virtual double CalculateInterest()
        {
            if (balance >= 0)
                return Balance * interest;
            return 0;
        }

        public void CreditInterest()
        {
            Deposit(CalculateInterest());
        }
    }
}
