using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class MediumDogWaterPot : IAbstractDogWaterPot
    {
        public int GetPotCapacityInMilliliters()
        {
            return 1500;
        }
    }
}
