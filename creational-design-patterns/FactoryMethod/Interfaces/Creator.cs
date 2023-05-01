namespace FactoryMethod.Interfaces
{
    // A classe Creator declara o factory method (CreateTransport) que deve retornar
    // um objeto de uma classe Transport (Ship ou Truck).
    // As classes que herdam de Creator fornecem a implementação deste método.
    public abstract class Creator
    {
        // O Creator também pode fornecer uma implementação
        // padrão para o método CreateTransport
        public abstract ITransport CreateTransport();

        // A principal responsabilidade do Creator não é criar transportes.
        // Geralmente, contém alguma lógica de negócios principal
        // que depende de objetos Transport, retornados pelo Factory Method (CreateTransport).
        // As subclasses (ConcreteCreators) podem alterar indiretamente essa lógica de negócios
        // sobreescrevendo o Factory Method (CreateTransport) retornando o tipo de Transporte.
        public void PlanDeliver()
        {
            // Chama o Factory Method para criar o Transporte
            ITransport t = CreateTransport();
            // Agora, usa o transporte criado.
            t.Deliver();
        }                
    }
}