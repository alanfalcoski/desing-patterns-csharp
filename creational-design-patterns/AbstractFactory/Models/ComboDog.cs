using AbstractFactory.Interfaces;
using AbstractFactory.Factories;

namespace AbstractFactory.Models
{
    internal class ComboDog
    {
        public IAbstractDogCollar abstractDogCollar;
        public IAbstractDogFoodPot abstractFoodPot;
        public IAbstractDogWaterPot abstractWaterPot;

        public ComboDog(string size)
        {
            if (size == "S")
            {
                ConcreteFactorySmallDog smallDogProducts = new ConcreteFactorySmallDog();                
                this.abstractDogCollar = smallDogProducts.CreateDogCollar();
                this.abstractFoodPot = smallDogProducts.CreateDogFoodPot();
                this.abstractWaterPot = smallDogProducts.CreateDogWaterPot();                
            } 
            else if(size  == "M")
            {
                ConcreteFactoryMediumDog mediumDogProducts = new ConcreteFactoryMediumDog();
                this.abstractDogCollar = mediumDogProducts.CreateDogCollar();
                this.abstractFoodPot = mediumDogProducts.CreateDogFoodPot();
                this.abstractWaterPot = mediumDogProducts.CreateDogWaterPot();                
            }            
            else
            {
                ConcreteFactoryMediumDog mediumDogProducts = new ConcreteFactoryMediumDog();
                this.abstractDogCollar = mediumDogProducts.CreateDogCollar();
                this.abstractFoodPot = mediumDogProducts.CreateDogFoodPot();
                this.abstractWaterPot = mediumDogProducts.CreateDogWaterPot();
            }
        }
    }
}
