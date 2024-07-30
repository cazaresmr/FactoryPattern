// See https://aka.ms/new-console-template for more information
using FactoryPattern;

PaymentMethod paymentMethod = PaymentMethod.CreditCard;
IPayment payment = PaymentFactory.CreatePaymentMethod(paymentMethod);
payment.Pay(100);

paymentMethod = PaymentMethod.GooglePay;
payment = PaymentFactory.CreatePaymentMethod(paymentMethod);
payment.Pay(200);

paymentMethod = PaymentMethod.PayPal;
payment = PaymentFactory.CreatePaymentMethod(paymentMethod);
payment.Pay(300);

paymentMethod = PaymentMethod.ApplePay;
payment = PaymentFactory.CreatePaymentMethod(paymentMethod);
payment.Pay(400);



