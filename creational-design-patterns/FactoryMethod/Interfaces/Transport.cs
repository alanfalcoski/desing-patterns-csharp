namespace FactoryMethod.Interfaces
{
    public interface Transport
    {
        public void Deliver();
        public virtual void DiscountRoadFee() { }
        public virtual double GetWeightCapacity() { return 0; }
    }
}
