using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class MediumDogFoodPot : IAbstractDogFoodPot
    {
        public int GetPotCapacityInMilligrams()
        {
            return 150;
        }
        public int GetCollarSize(IAbstractDogCollar collaborator)
        {
            return collaborator.GetCollarSize();
        }       
        public int GetPotCapacityInMilliliters(IAbstractDogWaterPot collaborator)
        {
            return collaborator.GetPotCapacityInMilliliters();
        }
    }
}
