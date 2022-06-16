namespace AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractDogFoodPot CreateDogFoodPot();

        IAbstractDogWaterPot CreateDogWaterPot();

        IAbstractDogCollar CreateDogCollar();
    }
}
