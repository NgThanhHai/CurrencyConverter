using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class Currency
    {
        public int rate;
        public object result;

        public Currency(int rate)
        {
            this.rate = rate;
        }

        public void convert(int usd) {

            result = rate * usd;
        }
    }
}
