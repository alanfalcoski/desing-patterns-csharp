using FactoryTemplateMethodCalculator.Strategy.Interfaces;
using FactoryTemplateMethodCalculator.Strategy.Models;

namespace FactoryTemplateMethodCalculator.Factory
{
    public interface ICalculationRuleFactory
    {
        IEnumerable<ICalculationRule> Create(Contract contract);
    }
}
