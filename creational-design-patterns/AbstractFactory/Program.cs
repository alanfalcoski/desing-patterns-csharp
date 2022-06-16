using AbstractFactory.Factories;

ConcreteFactorySmallDog smallDogProducts = new ConcreteFactorySmallDog();
Console.WriteLine("Small Sized Dog Products");
var collar3 = smallDogProducts.CreateDogCollar();
var foodPot3 = smallDogProducts.CreateDogFoodPot();
var waterPot3 = smallDogProducts.CreateDogWaterPot();
Console.WriteLine($"Food capacity: { foodPot3.GetPotCapacityInMilligrams() } ");
Console.WriteLine($"Collar size: { foodPot3.GetCollarSize(collar3) } ");
Console.WriteLine($"Water capacity: { foodPot3.GetPotCapacityInMilliliters(waterPot3) } ");

Console.WriteLine();


ConcreteFactoryMediumDog mediumDogProducts = new ConcreteFactoryMediumDog();
Console.WriteLine("Medium Sized Dog Products");
var collar2 = mediumDogProducts.CreateDogCollar();
var foodPot2 = mediumDogProducts.CreateDogFoodPot();
var waterPot2 = mediumDogProducts.CreateDogWaterPot();
Console.WriteLine($"Food capacity: { foodPot2.GetPotCapacityInMilligrams() } ");
Console.WriteLine($"Collar size: { foodPot2.GetCollarSize(collar2) } ");
Console.WriteLine($"Water capacity: { foodPot2.GetPotCapacityInMilliliters(waterPot2) } ");





