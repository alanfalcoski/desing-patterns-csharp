using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    // Concrete creators sobrescrevem o método de fábrica (CreateTransport)
    // para mudar o tipo de transporte retornado.
    public class ConcreteCreatorShip : Creator
    {
        // Observe que a assinatura do método ainda usa o ITransport,
        // mesmo que o produto concreto seja retornado do método.
        // Desta forma, o Creator é independente do produto concreto
        public override ITransport CreateTransport()
        {
            ITransport transport = new Ship("Titanic", "Gold", 102000.22);
            return transport;
        }       
    }
}
