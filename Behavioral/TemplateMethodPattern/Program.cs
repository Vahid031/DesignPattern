
using TemplateMethodPattern;

Console.WriteLine("Template method pattern sample");


IDiscountValidator discountValidator = new DiscountValidator();
IPaymentExecute paymentExecute = new PaymentExecute();
ICustomerNotify smsNotify = new SmsNotify();
ICustomerNotify emailNotify = new EmailNotify();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("Checkout with email notify");

Cart cart1 = new Cart(discountValidator, paymentExecute, emailNotify);
cart1.Checkout();

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("Checkout with sms notify");

Cart cart2 = new Cart(discountValidator, paymentExecute, smsNotify);
cart2.Checkout();