using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Demo.Adapter.Interface;

namespace Design_Patterns_Demo.Adapter.Implementation
{
    // Client (Works with IPaymentProcessor)
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void MakePayment(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
