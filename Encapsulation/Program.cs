namespace Encapsulation
{

    //Encapsulation is the practice of hiding an object's
    //internal details and exposing only what is necessary
    //through controlled access.

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
