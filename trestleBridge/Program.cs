using trestleBridge;
using trestleBridge.Actions;
using trestleBridge.Enums;
using trestleBridge.Extensions;

static void DisplayBanner()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
    Console.WriteLine();
}

static void Setup()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.Clear(); //clears the blank screen to show the setup colors
}

static void Start()
{
    Farm Trestlebridge = new Farm();
    bool runProgram = true;
    while (runProgram)
    {
        MainMenuOption? option = MainMenuOption.Invalid;
        var menu = option.DisplayAsMenu<MainMenuOption>("Choose a FARMS option");

        DisplayBanner();
        Console.Write(menu);

        try
        {
            option = (MainMenuOption)int.Parse(Console.ReadLine() ?? "");
        }
        catch (Exception)
        {
            option = MainMenuOption.Invalid;
        }

        switch (option)
        {
            case MainMenuOption.CreateFacility:
                DisplayBanner();
                CreateFacility.CollectInput(Trestlebridge);
                break;

            case MainMenuOption.PurchaseAnimals:
                DisplayBanner();
                PurchaseStock.CollectInput(Trestlebridge);
                break;

            case MainMenuOption.PurchaseSeeds:
                Console.WriteLine($"{option.GetDescription()} is still under construction.  Check back later!  Press Enter to proceed...");
                Console.ReadLine();
                //PurchaseSeed.CollectInput(Trestlebridge);
                break;

            case MainMenuOption.ProcessingOptions:
                Console.WriteLine($"{option.GetDescription()} is still under construction.  Check back later!  Press Enter to proceed...");
                Console.ReadLine();
                //ProcessResources(Trestlebridge);
                break;

            case MainMenuOption.FarmStatus:
                DisplayBanner();
                Console.WriteLine(Trestlebridge);
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Press return key to go back to main menu.");
                Console.ReadLine();
                break;

            case MainMenuOption.Exit:
                Console.WriteLine("Today is a great day for farming");
                runProgram = false;
                break;

            default:
                Console.WriteLine($"Invalid option: {option}");
                break;
        }
    }
}

Setup();
Start();