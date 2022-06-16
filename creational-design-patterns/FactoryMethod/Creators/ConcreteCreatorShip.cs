using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class ConcreteCreatorShip : Creator
    {               
        public override Transport CreateTransport()
        {
            Transport transport = new Ship("Titanic", "Gold", 102000.22);
            return transport;
        }       
    }
}
