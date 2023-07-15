namespace TemplateMethodPattern;

public interface IPaymentExecute
{
    void Execute();
}

public class PaymentExecute : IPaymentExecute
{
    public void Execute()
    {
        Console.WriteLine("Payment Execute has been succeeded");
    }
}