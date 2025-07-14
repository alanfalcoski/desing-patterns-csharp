using FactoryTemplateMethodCalculator.Strategy.Interfaces;

namespace FactoryTemplateMethodCalculator.Strategy.Models.Rules
{
    public class MultaRule : ICalculationRule
    {
        public static string Name => "Multa";

        public void Apply(CalculationContext context, InstallmentCalculationResult result)
        {
            var installment = context.Installment;
            var contract = context.Contract;

            if (installment.DueDate < DateTime.Today && installment.PaymentDate == null)
            {
                decimal multa = installment.BaseAmount * contract.TaxaMulta;
                result.Multa = multa;
            }
        }
    }
}
