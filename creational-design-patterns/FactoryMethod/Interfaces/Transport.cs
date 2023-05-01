namespace FactoryMethod.Interfaces
{
    // A Interface ITransport declara métodos que os Transportes devem implementar
    // Utiliza-se virtual quando não é necessário implementar em todas as classes.
    public interface ITransport
    {
        public void Deliver();
        public virtual void DiscountRoadFee() { }
        public virtual double GetWeightCapacity() { return 0; }
    }
}
