using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Common
{
    public class SD
    {
        public const string Shoppingcart = "ShoppingCart";

        // order status
        public const string Status_Pending = "Pending";
        public const string Status_Confirmed = "Confirmed";
        public const string Status_Shipped = "Shipped";
        public const string Status_Refunded = "Refunded";
        public const string Status_Cancelled = "Cancelled";

        // user roles
        public const string Role_Admin = "Admin";
        public const string Role_Customer = "Customer";
    }
}
