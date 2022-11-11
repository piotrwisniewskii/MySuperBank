using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance,decimal creditLimit) : base(name, initialBalance)
        {
        }
        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) => isOverdrawn ? new Transaction(-20, DateTime.Now, "Apply overdraft fee") : default;

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
    }
}
