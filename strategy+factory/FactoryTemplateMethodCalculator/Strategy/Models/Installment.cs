namespace FactoryTemplateMethodCalculator.Strategy.Models
{
    public class Installment
    {
        public Guid Id { get; set; }
        public decimal BaseAmount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal PaidAmount { get; set; }
    }
}
