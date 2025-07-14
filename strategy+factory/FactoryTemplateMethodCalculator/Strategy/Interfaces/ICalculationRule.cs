using FactoryTemplateMethodCalculator.Strategy.Models;

namespace FactoryTemplateMethodCalculator.Strategy.Interfaces
{
    public interface ICalculationRule
    {
        void Apply(CalculationContext context, InstallmentCalculationResult result);
    }

}
