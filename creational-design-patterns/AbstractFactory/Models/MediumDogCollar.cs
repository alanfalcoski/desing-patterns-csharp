using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class MediumDogCollar : IAbstractDogCollar
    {     
        public int GetCollarSize()
        {
            return 200;
        }
    }
}
