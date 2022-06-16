namespace FactoryMethod.Interfaces
{
    public abstract class Creator
    {
        public abstract Transport CreateTransport();
        public void PlanDeliver()
        {
            Transport t = CreateTransport();
            t.Deliver();
        }                
    }
}