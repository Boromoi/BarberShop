using System;
using System.Collections.Generic;

namespace BarberShop.Domain
{
    public class Prices
    {
        public int PricesId { get; set; }
        public int HairPrices { get; set; }
        public List <HairStylePrices> HairStylePrices { get; set; }
    }
}
