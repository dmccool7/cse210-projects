using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public float getTotalCost()
    {
        float cost = 0;
        foreach (Product product in _products)
        {
            cost += product.getTotalCost();
        }
        cost += _customer.livesUS() ? 5 : 35;
        return cost;
    }

    public string getPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $" - {product.getName()} (ID: {product.getProductId()})";
        }
        return label;
    }

    public string getShippingLabel()
    {
        return $"Shipping Label:\n - {_customer.getName()}\n - {_customer.GetAddress().getFullAddress()}";
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }
}