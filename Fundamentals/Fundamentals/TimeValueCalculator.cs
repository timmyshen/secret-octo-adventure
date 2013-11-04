using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class TimeValueCalculator
    {
        Value value;

        InterestRate interestRate;

        public decimal FutureValue(decimal time)
        {
            return value.Amount * (1 + interestRate.Rate * time);
        }
    }
}
