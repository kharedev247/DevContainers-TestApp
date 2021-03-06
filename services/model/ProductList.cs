using System;

namespace backend_service
{
    public class ProductList
    {
        public DateTime AddedAt { get; set; }

        public int PriceInDollar { get; set; }

        public int PriceInINR => 72 * (int)(PriceInDollar);

        public string ProductDescription { get; set; }
    }
}
