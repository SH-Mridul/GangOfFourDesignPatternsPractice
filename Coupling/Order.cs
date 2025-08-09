using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    public class Order
    {
        private readonly INotificationService _notificationService;
        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            _notificationService.SendNotification("Your order is placed successfully");
        }
    }
}
