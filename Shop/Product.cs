// ReSharper disable file MemberCanBePrivate.Global
namespace Shop;

public struct Product
{
    public readonly string Name;
    public readonly string ShopName;
    public readonly double Price;

    public Product(string name, string shopName, double price)
    {
        Name = name;
        ShopName = shopName;
        Price = price;
    }

    public void Print()
    {
        var space = new string(' ', 3);
        Console.WriteLine($"{space}- Product Name: \"{Name}\"");
        Console.WriteLine($"{space}  Shop Name: \"{ShopName}\"");
        Console.WriteLine($"{space}  Product Price: {Price:F2} рублей\n");
    }
}