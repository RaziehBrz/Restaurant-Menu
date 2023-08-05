class PrintMenuOptions
{
    public static void PrintFoods(Food[] foods)
    {
        foreach (var food in foods)
        {
            Console.WriteLine("------------------");
            food.PrintBasicInfo();
            food.GetAdditionalInfo();
            Console.WriteLine("------------------");
        }
    }
    public static void PrintDrinks(Drink[] drinks)
    {
        foreach (var drink in drinks)
        {
            Console.WriteLine("------------------");
            drink.PrintBasicInfo();
            drink.GetAdditionalInfo();
            Console.WriteLine("------------------");
        }
    }
}
