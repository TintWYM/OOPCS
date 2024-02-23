using System;
namespace Workshop_Inheritence
{
	public class OverdraftAccount: Account
	{
		public static double penalty = 0.06;
        public override double interest => 0.0025;

		public OverdraftAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance) { }

		public override double CalculateInterest() {
			if (Balance >= 0)
			{
				return Balance * interest;
			}
			else {
				return Balance * penalty;
			}
		}

		public override bool Withdraw(double amt) {
			Balance -= amt;

			return true;
		}
	}
}

