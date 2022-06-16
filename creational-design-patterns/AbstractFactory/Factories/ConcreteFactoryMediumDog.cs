using AbstractFactory.Models;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class ConcreteFactoryMediumDog : IAbstractFactory

    {
        public IAbstractDogCollar CreateDogCollar()
        {
            return new MediumDogCollar();
        }

        public IAbstractDogFoodPot CreateDogFoodPot()
        {
            return new MediumDogFoodPot();
        }

        public IAbstractDogWaterPot CreateDogWaterPot()
        {
            return new MediumDogWaterPot();
        }
    }
}
