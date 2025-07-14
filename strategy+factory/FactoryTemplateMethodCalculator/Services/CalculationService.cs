using FactoryTemplateMethodCalculator.Factory;
using FactoryTemplateMethodCalculator.Strategy.Models;

namespace FactoryTemplateMethodCalculator.Services
{
    public class CalculationService
    {
        private readonly ICalculationRuleFactory _factory;

        public CalculationService(ICalculationRuleFactory factory)
        {
            _factory = factory;
        }

        public IReadOnlyList<InstallmentCalculationResult> Calculate(Contract contract)
        {
            var results = new List<InstallmentCalculationResult>();
            var rules = _factory.Create(contract);

            foreach (var installment in contract.Installments)
            {
                var context = new CalculationContext(contract, installment);
                var result = new InstallmentCalculationResult(installment.Id);

                foreach (var rule in rules)
                    rule.Apply(context, result);

                result.TotalAmount =
                    installment.BaseAmount
                    + result.Mora
                    + result.Multa
                    + result.InflationCorrection
                    + result.Residual
                    - result.Discount;

                results.Add(result);
            }

            return results;
        }

    }
}
