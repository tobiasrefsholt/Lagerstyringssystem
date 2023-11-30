namespace Lagerstyringssystem;

public class Electronics : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Warranty { get; set; }

    public Electronics(string name, double price, int warranty)
    {
        Name = name;
        Price = price;
        Warranty = warranty;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Produkt: {Name} - Pris: {Price}kr - Garanti: {Warranty} måneder");
    }
}