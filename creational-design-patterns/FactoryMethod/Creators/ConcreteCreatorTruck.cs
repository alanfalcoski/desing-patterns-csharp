using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class ConcreteCreatorTruck : Creator
    {
        public override Transport CreateTransport()
        {
            Transport transport = new Truck(728, 20000.00);
            return transport;
        }                
    }
}
