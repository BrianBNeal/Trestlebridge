using System.ComponentModel;
using System.Runtime.Serialization;
using trestleBridge.Extensions;

namespace trestleBridge.Enums
{
    public enum MainMenuOption
    {
        Invalid = 0,
        [Description("Create Facility")]
        CreateFacility,
        [Description("Purchase Animals")]
        PurchaseAnimals,
        [Description("Purchase Seeds")]
        PurchaseSeeds,
        [Description("Processing Options")]
        ProcessingOptions,
        [Description("Display Farm Status")]
        FarmStatus,
        [Description("Exit")]
        Exit,
    }
}