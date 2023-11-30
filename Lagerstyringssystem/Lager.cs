using Microsoft.VisualBasic;

namespace Lagerstyringssystem;

public class Lager
{
    private List<IProduct> _products;

    public void AddProduct(IProduct product)
    {
        
    }

    public void RemoveProduct(IProduct product)
    {
        
    }

    public void ShowProducts()
    {
        foreach (var product in _products)
        {
            product.PrintInfo();
        }
    }
}