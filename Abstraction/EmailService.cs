using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending Email....");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connecting email server.....");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating....");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server....");
        }
    }
}
