using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PaymentFactory
    {
        public static IPayment CreatePaymentMethod(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();
                case PaymentMethod.PayPal:
                    return new PayPalPayment();
                case PaymentMethod.ApplePay:
                    return new ApplePayPayment();
                default:
                    throw new Exception("Invalid Payment Method");
            }
        }
    }
}