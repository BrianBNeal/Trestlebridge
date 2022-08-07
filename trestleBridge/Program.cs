using trestleBridge;
using trestleBridge.Actions;
using trestleBridge.Enums;
using trestleBridge.Extensions;

static void DisplayBanner()
{
    // Console.Clear();
    Console.WriteLine();
    Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
    Console.WriteLine();
}

static void Start()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Farm Trestlebridge = new Farm();
    bool runProgram = true;
    while (runProgram)
    {
        DisplayBanner();
        DisplayMenuOptions();

        MainMenuOption option = MainMenuOption.Invalid;

        try
        {
            option = (MainMenuOption)int.Parse(Console.ReadLine());
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
                UnderConstruction(option);
                //PurchaseSeed.CollectInput(Trestlebridge);
                break;

            case MainMenuOption.ProcessingOptions:
                UnderConstruction(option);
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

static void UnderConstruction(MainMenuOption option)
{
    Console.WriteLine($"{option.GetDescription()} is still under construction.  Check back later!");
}

static void DisplayMenuOptions()
{
    List<MainMenuOption> options = ((MainMenuOption[])Enum.GetValues(typeof(MainMenuOption)))
                                                    .Where(option => option != MainMenuOption.Invalid)
                                                    .ToList();
    foreach (MainMenuOption option in options)
    {
        Console.WriteLine($"{(int)option}. {option.GetDescription()}");
    }
    Console.WriteLine();
    Console.WriteLine("Choose a FARMS option");
    Console.Write("> ");
}

Start();