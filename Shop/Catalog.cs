namespace Shop;

public class Catalog
{
    private List<Product> _products;

    public Catalog()
    {
        _products = new List<Product>();
    }

    public void AppendProduct(Product product)
    {
        _products = _products.Append(product).ToList();
    }

    public void AppendProduct(string productName, string shopName, double productPrice)
    {
        var product = new Product(productName, shopName, productPrice);
        _products = _products.Append(product).ToList();
    }

    public void Sort(Func<Product, dynamic> action)
    {
        _products = _products.OrderBy(action).ToList();
    }

    public void SearchByProductName(string productName)
    {
        var temperance = _products.Where(product => product.Name.Length >= productName.Length).ToArray();
        var result = temperance.Where(product => product.Name[..productName.Length] == productName)
            .ToArray();
        if (result.Length == 0) throw new Exception("The product with this name will not be found");

        Console.WriteLine($"Found Products by name \"{productName}\":");
        foreach (var foundProduct in result) foundProduct.Print();
        Console.WriteLine();
    }

    public void SortByPrice()
    {
        _products = _products.OrderBy(product => product.Price).ToList();
    }

    public void Print()
    {
        Console.WriteLine("Catalog Products:");
        foreach (var product in _products)
        {
            product.Print();
        }

        Console.WriteLine();
    }
}