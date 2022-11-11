using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class GiftCardAccount : BankAccount
    {
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit) : base(name, initialBalance)
        {
            _monthlyDeposit = monthlyDeposit;
        }

        private readonly decimal _monthlyDeposit = 0m;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
