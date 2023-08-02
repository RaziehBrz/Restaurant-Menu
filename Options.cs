abstract class Options
{
    public string Title { get; set; }
    public double Price { get; set; }
    public int Time { get; set; }

    public Options(string title, double price, int time)
    {
        Title = title;
        Price = price;
        Time = time;
    }
    public void PrintBasicInfo()
    {
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Price : " + Price);
        Console.WriteLine("Time (Minutes): " + Time);
    }
    public abstract void GetAdditionalInfo();
}
class Food : Options
{
    public string Country { get; set; }
    public Food(string title, double price, int time, string country) : base(title, price, time)
    {
        {
            Title = title;
            Price = price;
            Time = time;
            Country = country;
        }
    }
    public override void GetAdditionalInfo()
    {
        Console.WriteLine("Country : " + Country);
    }
}
class Drink : Options
{
    public string Type { get; set; }
    public Drink(string title, double price, int time, string type) : base(title, price, time)
    {
        {
            Title = title;
            Price = price;
            Time = time;
            Type = type;

        }
    }
    public override void GetAdditionalInfo()
    {
        Console.WriteLine("Type : " + Type);
    }
}