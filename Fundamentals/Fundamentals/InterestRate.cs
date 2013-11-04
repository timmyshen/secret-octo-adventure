using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    using Measure = Currencies.CurrencyEnum;

    class InterestRate
    {
        public InterestRate(decimal rate, RateFormatEnum format, Measure currency = Measure.USD)
        {
            this.rate = rate;
            this.format = format;
            this.currency = currency;
        }

        enum RateFormatEnum
        {
            Real,
            Percent,
            BasisPoints
        }

        decimal rate;

        public decimal Rate
        {
            get 
            {
                return this.rate;
            } 

            private set
            {
                this.rate = value;
            }
        }

        RateFormatEnum format;

        Measure currency;

        // todo: time
    }
}
