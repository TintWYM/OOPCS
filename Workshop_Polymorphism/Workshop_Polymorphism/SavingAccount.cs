using System;

namespace Workshop_Polymorphism
{
    public class SavingAccount : Account
    {
        public override double interest => 0.01;

        public SavingAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance) { }
    }
}

