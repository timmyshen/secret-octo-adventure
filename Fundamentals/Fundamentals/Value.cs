using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    using Measure = Currencies.CurrencyEnum;

    class Value : IComparable
    {
        public Value(decimal amount, Measure currency, DateTime valuationDateTime)
        {
            this.amount = amount;
            this.currency = currency;
            this.valuationDateTime = valuationDateTime;
        }

        decimal amount;

        public decimal Amount
        {
            get
            {
                return this.amount;
            }

            private set
            {
                this.amount = value;
            }
        }

        Measure currency;

        DateTime valuationDateTime;

        public int CompareTo(Value otherVal)
        {
            if (this.currency == otherVal.currency && this.valuationDateTime == otherVal.valuationDateTime)
            {
                return Convert.ToInt32(this.amount - otherVal.amount);
            }
            else
            {
                throw new NotImplementedException("Only implemented comparison between the same time and currency.");
            }
        }
    }
}
