using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Adapter.Implementation
{
    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    public class ThirdPartyPaymentGateway
    {
        public void PayNow(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} processed using ThirdPartyPaymentGateway.");
        }
    }
}
