using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Adapter.Interface
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
