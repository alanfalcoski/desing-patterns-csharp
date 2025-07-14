namespace FactoryTemplateMethodCalculator.Strategy.Models
{
    public class CalculationContext
    {
        public Contract Contract { get; set; }
        public Installment Installment { get; set; }

        public CalculationContext(Contract contract, Installment installment)
        {
            Contract = contract;
            Installment = installment;
        }
    }

}
