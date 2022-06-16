using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class SmallDogFoodPot : IAbstractDogFoodPot
    {
        public int GetPotCapacityInMilligrams()
        {
            return 100;
        }

        public int GetPotCapacityInMilliliters(IAbstractDogWaterPot collaborator)
        {
            return collaborator.GetPotCapacityInMilliliters();
        }

        public int GetCollarSize(IAbstractDogCollar collaborator)
        {
            return collaborator.GetCollarSize();
        }
    }
}
