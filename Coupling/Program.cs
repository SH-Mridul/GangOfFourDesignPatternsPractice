namespace Coupling
{

    //Coupling means how much one piece of code depends on another piece of code.
    //another way to say the degree of dependency between different classes
    public class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new(new EmailSender());
            order1.PlaceOrder();

            Order order2 = new(new SmsSender());
            order2.PlaceOrder();
        }
    }
}
