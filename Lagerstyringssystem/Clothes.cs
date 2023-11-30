namespace Lagerstyringssystem;

public class Clothes : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public ClothesSizes Size { get; set; }

    public Clothes(string name, double price, ClothesSizes size)
    {
        Name = name;
        Price = price;
        Size = size;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Produkt: {Name} - Pris: {Price}kr - Størrelse: {Size}");
    }
}