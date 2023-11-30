namespace Lagerstyringssystem;

public class Food : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public DateOnly ExpiryDate { get; set; }

    public Food(string name, double price, DateOnly expiryDate)
    {
        Name = name;
        Price = price;
        ExpiryDate = expiryDate;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Produkt: {Name} - Pris: {Price}kr - Utløpsdato: {ExpiryDate}");
    }
}