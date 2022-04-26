using System;
using System.Collections.Generic;
using System.Text;

namespace DomRia
{
    class Price
    {
        public double UkraineCurrency { get; set; }
        public double AmericanCurrency { get; set; }
        public double PricePerSquareMeter { get; set; }
        public Price()
        {
            UkraineCurrency = 0;
            AmericanCurrency = 0;
            PricePerSquareMeter = 0;
        }
        public Price(long ukrCurrency, long americanCurrency, long pricePerSquareMeter)
        {
            UkraineCurrency = ukrCurrency;
            AmericanCurrency = americanCurrency;
            PricePerSquareMeter = pricePerSquareMeter;
        }
    }
}