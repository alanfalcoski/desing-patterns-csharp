namespace AbstractFactory.Interfaces
{
    public interface IAbstractDogFoodPot
    {
        public int GetPotCapacityInMilligrams();
        public int GetPotCapacityInMilliliters(IAbstractDogWaterPot collaborator);
        public int GetCollarSize(IAbstractDogCollar collaborator);
    }
}
