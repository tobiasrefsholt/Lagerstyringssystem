namespace Lagerstyringssystem;

public class Clothes : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Size { get; set; }

    public void PrintInfo()
    {
        throw new NotImplementedException();
    }
}