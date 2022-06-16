using AbstractFactory.Interfaces;
namespace AbstractFactory.Models
{
    internal class SmallDogWaterPot : IAbstractDogWaterPot
    {
        public int GetPotCapacityInMilliliters()
        {
            return 700;
        }
    }
}
