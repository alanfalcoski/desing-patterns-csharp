using FactoryTemplateMethodCalculator.Factory;
using FactoryTemplateMethodCalculator.Services;
using FactoryTemplateMethodCalculator.Strategy.Enums;
using FactoryTemplateMethodCalculator.Strategy.Models;

class Program
{
    static void Main(string[] args)
    {
        var contrato = new Contract
        {
            Id = Guid.NewGuid(),
            Type = ContractType.Venda,
            HasResidual = true,
            TaxaDesconto = 0.05m,
            TaxaIndice = 0.02m,
            TaxaMora = 0.01m,
            TaxaMulta = 0.02m,
            ResidualValue = 20.45m,
            Installments = new List<Installment>
            {
                new Installment
                {
                    Id = Guid.NewGuid(),
                    BaseAmount = 1000m,
                    DueDate = DateTime.Today.AddDays(-10), // vencida
                    PaidAmount = 0
                },
                new Installment
                {
                    Id = Guid.NewGuid(),
                    BaseAmount = 1500m,
                    DueDate = DateTime.Today.AddDays(5), // ainda a vencer
                    PaidAmount = 0
                }
            }
        };

        // Instancia a fábrica e o serviço de cálculo
        var factory = new CalculationRuleFactory();
        var calculationService = new CalculationService(factory);

        // Executa o cálculo
        var resultados = calculationService.Calculate(contrato);

        // Exibe os resultados
        Console.WriteLine("Resultados dos Cálculos:");

        foreach (var result in resultados)
        {
            Console.WriteLine($"Parcela ID: {result.InstallmentId}");
            Console.WriteLine($"  Mora:                R$ {result.Mora:F2}");
            Console.WriteLine($"  Multa:               R$ {result.Multa:F2}");
            Console.WriteLine($"  Desconto:            R$ {result.Discount:F2}");
            Console.WriteLine($"  Correção (Inflação): R$ {result.InflationCorrection:F2}");
            Console.WriteLine($"  Resíduo:             R$ {result.Residual:F2}");
            Console.WriteLine($"  Total Final:         R$ {result.TotalAmount:F2}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
