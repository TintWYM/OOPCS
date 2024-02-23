using System;

namespace Workshop_Polymorphism
{
	public class BankBranch: Account
	{
		private List<Account> _accounts;

		public BankBranch(string name)
		{
			Name = name;
			_accounts = new List<Account>();
		}

		public string Name { set; get; }

		public void AddAccount(Account account) {
            _accounts.Add(account);
		}

		public void PrintAccounts() {
			foreach(Account account in _accounts) {
                Console.WriteLine(account);
            }
		}

		public double TotalDeposits() {
			double total = 0;

            foreach (Account account in _accounts)
            {
				if (account.Balance > 0) {
					total += account.Balance;
				}
            }

			return total;
        }

		public double TotalInterestPaid()
		{
            double total = 0;

            foreach (Account account in _accounts)
            {
                if (account.Balance > 0)
                {
                    total += account.CalculateInterest();
                }
            }
            return total;
        }

		public double TotalInterestEarn()
		{
            double total = 0;

            foreach (Account account in _accounts)
            {
                if (account.Balance < 0)
                {
                    total += account.CalculateInterest();
                }
            }

            return total;
        }

        public void PrintCustomers() {
            Dictionary<string, bool> hids = new Dictionary<string, bool>();

            foreach (Account account in _accounts) {
                string hid = account.AccountHolderId;

                if (!hids.ContainsKey(hid)) {
                    Console.WriteLine(hid);
                    hids[hid] = true;
                }
            }
        }
	}
}

