using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Ship : ITransport
    {
        public string ShipName { get; set; }
        public string Licence { get; set; }
        private double WeightCapacity { get; set; }

        public Ship(string shipName, string licence, double weightCapacity)
        {
            ShipName = shipName;
            Licence = licence;
            WeightCapacity = weightCapacity;
        }

        public void Deliver()
        {
            Console.WriteLine($"Entrega do produto ocorre pela água. Navio {this.ShipName}, Licence: {Licence}, WeightCapacity: {WeightCapacity}");
        }

    }
}
