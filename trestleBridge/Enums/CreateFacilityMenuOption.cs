using System.ComponentModel;

namespace trestleBridge.Enums
{
    internal enum CreateFacilityMenuOption
    {
        [Description("Invalid")]
        Invalid = 0,
        [Description("Grazing Field")]
        GrazingField,
        [Description("Plowed Field")]
        PlowedField,
        [Description("Natural Field")]
        NaturalField,
        [Description("Chicken House")]
        ChickenHouse,
        [Description("Duck House")]
        DuckHouse
    }
}
