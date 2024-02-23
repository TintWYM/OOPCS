using System;

namespace Workshop_Polymorphism
{
    public class CurrentAccount : Account
    {
        public override double interest => 0.0025;

        public CurrentAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance) { }
    }
}

