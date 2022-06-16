using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Truck : Transport
    {
        private int Identification;
        private double WeightCapacity;

        public Truck(int identification, double weigthCapacity)
        {
            Identification = identification;
            WeightCapacity = weigthCapacity;
        }
        public void Deliver()
        {
            Console.WriteLine($"Entrega do produto ocorre pela terra. Caminhão com a identificação {Convert.ToString(this.Identification)}");
        }

        public virtual void DiscountRoadFee()
        {
            Console.WriteLine("Descontado valor de pedágio: 164.00");
        }

        public virtual double GetWeightCapacity()
        {
            return this.WeightCapacity;
        }
    }
}
