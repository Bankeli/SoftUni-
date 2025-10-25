using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacementText = Displacement.HasValue ? Displacement.ToString() : "n/a";
            string efficiencyText = Efficiency ?? "n/a";
            return $"{Model}:\n" +
                   $"    Power: {Power}\n" +
                   $"    Displacement: {displacementText}\n" +
                   $"    Efficiency: {efficiencyText}";
        }
    }
}
