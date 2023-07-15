namespace TemplateMethodPattern;

public interface IDiscountValidator
{
    void Validate();
}

public class DiscountValidator : IDiscountValidator
{
    public void Validate()
    {
        Console.WriteLine("Discount has been validate");
    }
}