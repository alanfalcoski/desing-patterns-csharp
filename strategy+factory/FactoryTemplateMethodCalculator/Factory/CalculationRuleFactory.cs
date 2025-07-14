using FactoryTemplateMethodCalculator.Strategy.Interfaces;
using FactoryTemplateMethodCalculator.Strategy.Models;
using FactoryTemplateMethodCalculator.Strategy.Models.Rules;

namespace FactoryTemplateMethodCalculator.Factory
{
    public class CalculationRuleFactory : ICalculationRuleFactory
    {
        public IEnumerable<ICalculationRule> Create(Contract contract)
        {
            var rules = new List<ICalculationRule>
        {
            new MoraRule(),
            new MultaRule(),
            new InflationCorrectionRule()
        };

            if (contract.HasResidual)
                rules.Add(new ResidualRule());

            rules.Add(new DiscountRule());

            return rules;
        }
    }
}
