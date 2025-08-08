namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(100);
            Console.WriteLine(bankAccount.GetBlance());
            bankAccount.Deposit(100);
            Console.WriteLine(bankAccount.GetBlance());
            bankAccount.Withdraw(100);
            bankAccount.Withdraw(150);
            Console.WriteLine(bankAccount.GetBlance());
        }
    }
}
