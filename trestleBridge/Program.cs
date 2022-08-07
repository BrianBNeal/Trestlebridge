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
        
        string? option = Console.ReadLine();

        switch (option)
        {
            case "1":
                DisplayBanner();
                CreateFacility.CollectInput(Trestlebridge);
                break;

            case "2":
                DisplayBanner();
                PurchaseStock.CollectInput(Trestlebridge);
                break;

            case "3":
                break;

            case "4":
                DisplayBanner();
                Console.WriteLine(Trestlebridge);
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Press return key to go back to main menu.");
                Console.ReadLine();
                break;

            case "5":
                Console.WriteLine("Today is a great day for farming");
                runProgram = false;
                break;

            default:
                Console.WriteLine($"Invalid option: {option}");
                break;
        }
    }
}

static void DisplayMenuOptions()
{
    int counter = 1;
    foreach (MenuOption option in Enum.GetValues(typeof(MenuOption)))
    {
        Console.WriteLine($"{(int)option}. {option.GetDescription()}");
        counter++;
    }
    Console.WriteLine();
    Console.WriteLine("Choose a FARMS option");
    Console.Write("> ");
}

Start();