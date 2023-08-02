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
    public static void PrintDrinks(Drink[] dreinks)
    {
        foreach (var drink in dreinks)
        {
            Console.WriteLine("------------------");
            drink.PrintBasicInfo();
            drink.GetAdditionalInfo();
            Console.WriteLine("------------------");
        }
    }
}