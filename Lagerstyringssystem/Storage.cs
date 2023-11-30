using Microsoft.VisualBasic;

namespace Lagerstyringssystem;

public class Storage
{
    private List<IProduct> _products = new();

    public void AddProduct(IProduct product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(IProduct product)
    {
        _products.Remove(product);
    }
    
    public void RemoveProduct(int productIndex)
    {
        var product = _products[productIndex];
        RemoveProduct(product);
    }

    public void ShowProducts()
    {
        foreach (var product in _products)
        {
            product.PrintInfo();
        }
    }
}