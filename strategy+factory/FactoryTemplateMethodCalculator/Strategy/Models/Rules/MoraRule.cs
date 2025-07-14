using FactoryTemplateMethodCalculator.Strategy.Interfaces;

namespace FactoryTemplateMethodCalculator.Strategy.Models.Rules
{
    public class MoraRule : ICalculationRule
    {
        public static string Name => "Mora";

        public void Apply(CalculationContext context, InstallmentCalculationResult result)
        {
            var installment = context.Installment;
            var contract = context.Contract;

            if (installment.PaymentDate == null && installment.DueDate < DateTime.Today)
            {
                int diasAtraso = (DateTime.Today - installment.DueDate).Days;
                decimal mora = installment.BaseAmount * contract.TaxaMora * diasAtraso;
                result.Mora = mora;
            }
        }
    }
}
