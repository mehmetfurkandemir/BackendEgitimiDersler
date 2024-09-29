namespace Project21_OOP_Intro;

class Product
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description { get; set; }
    public decimal price;


}

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Name = "Samsung S23";
        System.Console.WriteLine(product1.Name);
    }
}
