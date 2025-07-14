using FactoryTemplateMethodCalculator.Strategy.Interfaces;

namespace FactoryTemplateMethodCalculator.Strategy.Models.Rules
{
    public class ResidualRule : ICalculationRule
    {
        public static string Name => "Resíduo";

        public void Apply(CalculationContext context, InstallmentCalculationResult result)
        {
            decimal residual = 5m;
            result.Residual = residual;
        }
    }
}
