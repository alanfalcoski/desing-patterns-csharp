using FactoryTemplateMethodCalculator.Strategy.Interfaces;

namespace FactoryTemplateMethodCalculator.Strategy.Models.Rules
{
    public class DiscountRule : ICalculationRule
    {
        public static string Name => "Desconto";

        public void Apply(CalculationContext context, InstallmentCalculationResult result)
        {
            var installment = context.Installment;
            var contract = context.Contract;

            if (installment.DueDate >= DateTime.Today)
            {
                decimal desconto = installment.BaseAmount * contract.TaxaDesconto;
                result.Discount = desconto;
            }
        }
    }
}
