using FactoryMethod.Interfaces;
using FactoryMethod.Creators;

Creator shipCreator = new ConcreteCreatorShip();
shipCreator.PlanDeliver();

Creator truckCreator = new ConcreteCreatorTruck();
truckCreator.PlanDeliver();

Transport truck = truckCreator.CreateTransport();
truck.DiscountRoadFee();
Console.WriteLine("Truck capacity: " + truck.GetWeightCapacity());

Console.ReadKey();

