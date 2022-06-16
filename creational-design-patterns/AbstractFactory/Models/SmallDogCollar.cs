using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class SmallDogCollar : IAbstractDogCollar
    {        
        public int GetCollarSize()
        {
            return 150;
        }
    }
}
