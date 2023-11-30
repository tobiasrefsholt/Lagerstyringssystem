namespace Lagerstyringssystem;

public class Food : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public DateOnly ExpiryDate { get; set; }

    public void PrintInfo()
    {
        throw new NotImplementedException();
    }
}