// See https://aka.ms/new-console-template for more information
using MySuperBank;

Console.WriteLine("Hello, World!");

var account = new BankAccount("Kendra",10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

account.MakeWithdrawal(120, DateTime.Now, "Hammock");
account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
Console.WriteLine(account.GetAccountHistory());

try
{
    account.MakeWithdrawal(-800009, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}

try
{
    var invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Excepetion caught creating account with negative balance");
    Console.WriteLine(e.ToString());
}

Console.WriteLine(account.Balance);
