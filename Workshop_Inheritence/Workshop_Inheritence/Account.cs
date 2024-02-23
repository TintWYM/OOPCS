using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Inheritence
{
    public class Account
    {
        /**
         * TODO: create attributes
         * This class has 3 attributes:
         * acctNumber : string, private
         * acctHolderId : string, private
         * balance: double, private
         */
        private string? acctHolderId;
        private double balance;
        public virtual double interest => 0;

        public Account() { }

        /**
         * TODO: create constructor
         * This contructor receives 3 values
         * and initializes the 3 attributes accordingly
         */
        public Account(string acctNumber, string acctHolderId, double balance)
        {
            acctNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
        }

        /**
         * TODO: create properties
         * These properties expose the private attributes
         *
         * Note: acctNumber should be read-only, i.e. can not be
         * set from outside
         */

        public string AccNumber { get; }

        public string AccHolderId { get => acctHolderId; set { acctHolderId = value; } }

        public double Balance { get => balance; set { balance = value; } }

        /**
         * TODO: implement method Deposit
         * This method increases the account balance 
         * by the given amount
         */

        public void Deposit(double amt) {
            Balance += amt;
        }


        /**
         * TODO: implement method Withdraw
         * This method decreases the account balance
         * by the given amount. Balance must NOT be negative.
         * It makes sure that there is enough balance to
         * widthdraw
         */

        public virtual bool Withdraw(double amt) {
            if (balance >= amt && balance >= 0) {
                balance -= amt;
                return true;
            }
            return false;
        }


        /**
         * TODO: implement method TransferTo
         * This method transfers a given amount to another given 
         * account. It makes sure that this sender has enough
         * balance before transfering
         */

        public void TransferTo(Account receiver, double amt) {
            if (this.Withdraw(amt)) {
                receiver.Deposit(amt);
            }
        }


        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         */

        public override string ToString()
        {
            return "Acc No is: " + AccNumber + "Acc Holder ID is: " + AccHolderId + "Balance is: " + Balance;
        }


        public virtual double CalculateInterest() {
            if (balance >= 0) 
                return Balance * interest;
            return 0;
        }

        public void CreditInterest() {
            Deposit(CalculateInterest());
        }
    }
}
