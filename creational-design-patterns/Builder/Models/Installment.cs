using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class Installment
    {
        public int Id { get; set; }
        public string? Sequence { get; set; }
        public double BaseValue { get; set; }
        public double Fees { get; set; }
        public double Taxes { get; set; }
        public DateTime DueDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}  \n" +
                   $"Sequence: {Sequence} \n" +
                   $"BaseValue: {BaseValue} \n" +
                   $"Fees: {Fees} \n" +
                   $"Taxes: {Taxes} \n" +
                   $"DueDate: {DueDate} \n";
        }
    }
    
}
