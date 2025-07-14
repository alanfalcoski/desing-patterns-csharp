using FactoryTemplateMethodCalculator.Strategy.Interfaces;

namespace FactoryTemplateMethodCalculator.Strategy.Models.Rules
{
    public class InflationCorrectionRule : ICalculationRule
    {
        public static string Name => "IndiceCorrecao";

        public void Apply(CalculationContext context, InstallmentCalculationResult result)
        {
            var installment = context.Installment;
            int dias = (DateTime.Today - installment.DueDate).Days;
            if (dias > 0)
            {
                decimal fator = 0.003m / 30 * dias;
                decimal correcao = installment.BaseAmount * fator;
                result.InflationCorrection = correcao;
            }
        }
    }
}
