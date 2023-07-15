namespace TemplateMethodPattern;

public class Cart
{
    private readonly IDiscountValidator _discountValidator;
    private readonly IPaymentExecute _paymentExecute;
    private readonly ICustomerNotify _customerNotify;

    public Cart(IDiscountValidator discountValidator, 
        IPaymentExecute paymentExecute, 
        ICustomerNotify customerNotify)
    {
        _discountValidator = discountValidator;
        _paymentExecute = paymentExecute;
        _customerNotify = customerNotify;
    }


    public void Checkout()
    {
        _discountValidator.Validate(); 
        _paymentExecute.Execute();
        _customerNotify.Notify();
    }
}