// See https://aka.ms/new-console-template for more information
using MySuperBank;

Console.WriteLine("Hello, World!");

var account = new BankAccount("Kendra",10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

account.MakeWithdrawal(120, DateTime.Now, "Hammock");
account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
Console.WriteLine(account.GetAccountHistory());

//try
//{
//    account.MakeWithdrawal(-800009, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}

//try
//{
//    var invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Excepetion caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//}

//Console.WriteLine(account.Balance);

var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
// additional deposit
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("saving account", 10000);
savings.MakeDeposit(750, DateTime.Now, "same some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());

var lineOfCredit = new LineOfCreditAccount("line of credit", 0,0);
// How much is too much to borrow?
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pat back small amount");
lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
lineOfCredit.PerformMonthEndTransactions();
Console.WriteLine(lineOfCredit.GetAccountHistory());
