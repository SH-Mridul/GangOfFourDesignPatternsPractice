namespace Abstraction
{

    //Abstraction means showing only the important details
    //and hiding the extra stuff.

    public class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            emailService.SendEmail();
        }
    }
}
