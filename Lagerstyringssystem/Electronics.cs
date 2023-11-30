namespace Lagerstyringssystem;

public class Electronics : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Warranty { get; set; }

    public void PrintInfo()
    {
        throw new NotImplementedException();
    }
}