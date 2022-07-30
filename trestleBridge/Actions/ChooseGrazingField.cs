using System;
namespace trestleBridge.Actions
{
	public class ChooseGrazingField
	{
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();
            List<GrazingField> OpenGrazingFields = new List<GrazingField>();

            foreach (GrazingField grazingField in farm.GrazingFields)
            {
                if (grazingField.Animals.Count < grazingField.Capacity)
                {
                    OpenGrazingFields.Add(grazingField);
                }
            }

            for (int i = 0; i < OpenGrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field ({OpenGrazingFields[i].Animals.Count} animals - {OpenGrazingFields[i].Cows()} cow, {OpenGrazingFields[i].Pigs()} pig, {OpenGrazingFields[i].Goats()} goat, {OpenGrazingFields[i].Ostriches()} ostrich, {OpenGrazingFields[i].Sheep()} sheep) ");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {animal.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            try
            {
                if (OpenGrazingFields[choice - 1].Animals.Count < OpenGrazingFields[choice - 1].Capacity)
                {
                    OpenGrazingFields[choice - 1].AddResource(animal);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"{choice} is not a valid option");
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}

