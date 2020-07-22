using System;
using System.Collections.Generic;

namespace BarberShop.Domain
{
    public class HairStyle
    {
        public int HairStyleId { get; set; }
        public string HairStylesName { get; set; }
        public List<HairStylePrices> HairStylePrices { get; set; }
    }  
}
