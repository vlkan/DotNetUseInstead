public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

public class ProductPrimaryCtor(int id, string name, decimal price)
{
    public int Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public decimal Price { get; private set; } = price;
}