using FactoryMethod.Interfaces;
using FactoryMethod.Creators;

//O Factory Method é um padrão de projeto criacional que fornece
//uma interface para criar objetos em uma superclasse, mas permite
//que as subclasses alterem o tipo de objetos que serão criados.

Creator shipCreator = new ConcreteCreatorShip();
shipCreator.PlanDeliver();

Creator truckCreator = new ConcreteCreatorTruck();
truckCreator.PlanDeliver();

ITransport truck = truckCreator.CreateTransport();
truck.DiscountRoadFee();

Console.ReadKey();

