using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ApplePayPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Payment made by Apple Pay: ${amount}");
        }
    }

}