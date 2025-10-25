
using System.ComponentModel;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string weightText = Weight.HasValue ? Weight.ToString() : "n/a";
            string colorText = Color ?? "n/a";
            return $"{Model}:\n" +
                   $"  {Engine.ToString()}\n" +
                   $"  Weight: {weightText}\n" +
                   $"  Color: {colorText}";
        }

    }
}
