using AbstractFactory.Models;

using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class ConcreteFactorySmallDog : IAbstractFactory
    {
        public IAbstractDogCollar CreateDogCollar()
        {
            return new SmallDogCollar();            
        }

        public IAbstractDogFoodPot CreateDogFoodPot()
        {
            return new SmallDogFoodPot();
        }

        public IAbstractDogWaterPot CreateDogWaterPot()
        {
            return new SmallDogWaterPot();
        }
    }
}
