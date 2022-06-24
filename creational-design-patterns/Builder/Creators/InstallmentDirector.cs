using Builder.Interfaces;
using Builder.Models;

namespace Builder.Creators
{
    internal class InstallmentDirector
    {
        private IInstallment _builder;

        public IInstallment Builder
        {
            set { _builder = value; }
        }

        public Installment BuildInstallmentWithoutFeesAndTaxes()
        {
            this._builder.WithId(1);
            this._builder.WithSequence("001/100");
            this._builder.WithBaseValue(1000.0);            
            this._builder.WithDueDate(new DateTime(2022, 06, 30));
            return this._builder.GetResult();
        }

        public Installment BuildFullInstallment()
        {
            this._builder.WithId(2);
            this._builder.WithSequence("002/100");
            this._builder.WithBaseValue(1000.0);
            this._builder.WithTaxes(1000.0 * (0.02));
            this._builder.WithFees(113.0);
            this._builder.WithDueDate(new DateTime(2022, 06, 30));           
            return this._builder.GetResult();
        }
    }
}
