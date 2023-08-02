internal class Program
{
    private static void Main(string[] args)
    {
        bool runAgain = true;

        Food[] foods = new Food[]
                                    { new Food ("Burger" , 790000 , 20 , "America") ,
                                      new Food ("Pizza" , 112000 , 25 , "Italy") ,
                                      new Food ("Chicken soup" , 590000 , 30 , "America") ,
                                      new Food ("Fried Chicken" , 139000 , 40 , "America") ,
                                    };

        Drink[] drinks = new Drink[]
                                       {
                                      new Drink ("Lemonade" , 49000 , 15 , "Cold") ,
                                      new Drink ("Tea" , 20.900 , 10 , "Hot" ) ,
                                      new Drink ("Coffee" , 59000 , 20 , "Hot")

                                       };

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the restaurant ^-^ ");
        Console.ResetColor();

        Console.WriteLine("Please press enter to continue ");

        Console.ReadLine();

        while (runAgain)
        {
            Console.Clear();

            PrintMenu();
            var inputNumber = Console.ReadLine();

            Console.Clear();

            SelectedOption(inputNumber, foods, drinks);

            Console.WriteLine("Would you like to continue ? Y/N");
            var answer = Console.ReadLine();
            runAgain = answer.ToUpper() == "Y";
        }
    }

    static void PrintMenu()
    {
        Console.WriteLine("Menu : ");
        Console.WriteLine("1) Foods");
        Console.WriteLine("2) Drinks");
        Console.WriteLine("3) Exit\n");
        Console.WriteLine("Enter the number of Option : ");

    }

    static void SelectedOption(string inputNumber, Food[] foods, Drink[] drinks)
    {
        switch (inputNumber)
        {
            case "1":
                PrintMenuOptions.PrintFoods(foods);
                break;
            case "2":
                PrintMenuOptions.PrintDrinks(drinks);
                break;
            case "3":
                Console.WriteLine("Good bye :)");
                Environment.Exit(0);
                break;
            default:
                throw new Exception("You Entered wrong option !! Try again .");
        }
    }
}