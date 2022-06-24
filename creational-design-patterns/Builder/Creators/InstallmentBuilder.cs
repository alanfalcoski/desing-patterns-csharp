using Builder.Interfaces;
using Builder.Models;

namespace Builder.Creators
{
    internal class InstallmentBuilder : IInstallment
    {
        private Installment _installment = new Installment();

        public InstallmentBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._installment = new Installment();
        }
        public Installment WithBaseValue(double baseValue)
        {
            this._installment.BaseValue = baseValue;
            return this._installment;
        }
        public Installment WithDueDate(DateTime dueDate)
        {
            this._installment.DueDate = dueDate;
            return this._installment;
        }

        public Installment WithFees(double fees)
        {
            this._installment.Fees = fees;
            return this._installment;
        }

        public Installment WithId(int id)
        {
            this._installment.Id = id;
            return this._installment;
        }
        public Installment WithSequence(string sequence)
        {
            this._installment.Sequence = sequence;
            return this._installment;
        }

        public Installment WithTaxes(double taxes)
        {
            this._installment.Taxes = taxes;
            return this._installment;
        }
        public Installment GetResult()
        {
            Installment result = this._installment;
            this.Reset();
            return result;
        }
    }
}
