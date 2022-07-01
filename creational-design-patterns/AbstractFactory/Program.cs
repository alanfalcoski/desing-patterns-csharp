using AbstractFactory.Factories;
using AbstractFactory.Models;
using System.Text;

string ?sizeResponse = String.Empty;
bool correctEntry = false;
bool exit = false;

while (!exit)
{
    Console.WriteLine("Which's the dog's size? [S]mall or [M]edium?");
    while (!correctEntry)
    {
        sizeResponse = Console.ReadLine();
        if (AcceptSizes().Contains(sizeResponse))
            correctEntry = true;
        else
            ShowAcceptedOptions();          
    }
    Console.Write(ShowSelectedSize());
    Console.Write(ShowProductsFamily());
    ClearOptions();
    AskExitProgram();
}

string ShowSelectedSize()
{
    var selected = sizeResponse == "S" ? "Small" : "Medium";
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine();    
    stringBuilder.AppendLine($"Selected {selected} dog's sized");    
    stringBuilder.AppendLine();
    return stringBuilder.ToString();
}

string ShowProductsFamily()
{
    StringBuilder stringBuilder = new StringBuilder();
    ComboDog comboDog = new ComboDog(sizeResponse);
    stringBuilder.AppendLine($"Food capacity: { comboDog.abstractFoodPot.GetPotCapacityInMilligrams() } ");
    stringBuilder.AppendLine($"Collar size: { comboDog.abstractFoodPot.GetCollarSize(comboDog.abstractDogCollar) } ");
    stringBuilder.AppendLine($"Water capacity: { comboDog.abstractFoodPot.GetPotCapacityInMilliliters(comboDog.abstractWaterPot) } ");
    return stringBuilder.ToString();
}

void ClearOptions()
{
    sizeResponse = String.Empty;
    correctEntry = false;
    exit = false;
}

void AskExitProgram()
{
    Console.WriteLine();
    Console.WriteLine("[E]xit?");
    if (Console.ReadLine() == "E")
        exit = true;
    else 
        exit = false;
}

List<string> AcceptSizes()
{
    List<string> accept = new List<string>();
    accept.Add("S");
    accept.Add("M");
    return accept;
}
void ShowAcceptedOptions()
{
    Console.Write("Maybe Option ");
    AcceptSizes().ForEach(p => {
        Console.Write($"- {p} ");
    });
    Console.Write("?");
}