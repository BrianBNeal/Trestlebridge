using System.ComponentModel;
using System.Runtime.Serialization;
using trestleBridge.Extensions;

namespace trestleBridge.Enums
{
    public enum MenuOption
    {
        [Description("Create Facility")]
        CreateFacility = 1,
        [Description("Purchase Animals")]
        PurchaseAnimals,
        [Description("Purchase Seeds")]
        PurchaseSeeds,
        [Description("ProcessingOptions")]
        ProcessingOptions,
        [Description("Display Farm Status")]
        FarmStatus,
        [Description("Exit")]
        Exit,
    }
}
