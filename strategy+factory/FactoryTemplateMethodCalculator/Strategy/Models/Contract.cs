using FactoryTemplateMethodCalculator.Strategy.Enums;

namespace FactoryTemplateMethodCalculator.Strategy.Models
{
    public class Contract
    {
        public Guid Id { get; set; }
        public List<Installment> Installments { get; set; } = new();
        public bool HasResidual { get; set; }
        public ContractType Type { get; set; }
        public decimal TaxaMora { get; set; }
        public decimal TaxaDesconto { get; set; }
        public decimal TaxaMulta { get; set; }
        public decimal TaxaIndice { get; set; }
        public decimal ResidualValue { get; set; }
    }
}
