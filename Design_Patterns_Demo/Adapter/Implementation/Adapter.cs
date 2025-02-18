using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Demo.Adapter.Interface;

namespace Design_Patterns_Demo.Adapter.Implementation
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class PaymentGatewayAdapter : IPaymentProcessor
    {
        private readonly ThirdPartyPaymentGateway _thirdPartyGateway;

        public PaymentGatewayAdapter(ThirdPartyPaymentGateway thirdPartyGateway)
        {
            _thirdPartyGateway = thirdPartyGateway;
        }

        public void ProcessPayment(decimal amount)
        {
            _thirdPartyGateway.PayNow(amount);
        }
    }

}
