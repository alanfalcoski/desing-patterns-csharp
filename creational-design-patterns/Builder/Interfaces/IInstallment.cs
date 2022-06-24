using Builder.Models;

namespace Builder.Interfaces
{
    internal interface IInstallment
    {
        Installment WithId(int id);
        Installment WithSequence(string sequence);
        Installment WithDueDate(DateTime dueDate);
        Installment WithBaseValue(double baseValue);
        Installment WithFees(double fees);
        Installment WithTaxes(double taxes);
        void Reset();
        Installment GetResult();
    }
}
