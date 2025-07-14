namespace FactoryTemplateMethodCalculator.Strategy.Models
{
    public class InstallmentCalculationResult
    {
        public Guid InstallmentId { get; set; }
        public decimal Mora { get; set; }
        public decimal Multa { get; set; }
        public decimal Discount { get; set; }
        public decimal InflationCorrection { get; set; }
        public decimal Residual { get; set; }
        public decimal TotalAmount { get; set; }

        public InstallmentCalculationResult(Guid installmentId)
        {
            InstallmentId = installmentId;
        }
    }
}
