namespace TemplateMethodPattern;

public interface ICustomerNotify
{
    void Notify();
}

public class SmsNotify : ICustomerNotify
{
    public void Notify()
    {
        Console.WriteLine("Sms has been sent");
    }
}

public class EmailNotify : ICustomerNotify
{
    public void Notify()
    {
        Console.WriteLine("Email has been sent");
    }
}
