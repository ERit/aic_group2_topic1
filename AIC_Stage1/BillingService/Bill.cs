using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingService
{
    public class Bill
    {
        private const double DEFAULT_PRICE_PER_DAY = 1.0;
        private const double DEFAULT_PRICE_PER_QUERY = 3.0;


        public Bill(int id, int userId, double price, bool isPayed, DateTime accountedUntil, DateTime created)
        {
            this.id = id;
            this.userId = userId;
            this.price = price;
            this.isPayed = isPayed;
            this.accountedUntil = accountedUntil;
            this.created = created;
        }

        public Bill()
        {
        }

        public int id { get; set; }
        public int userId { get; set; }
        public double price { get; set; }
        public bool isPayed { get; set; }
        public DateTime accountedUntil { get; set; }
        public DateTime created { get; set; }


        public void calculatePrice(int daysAccouned, int queriesAccounted)
        {
            double pricePerDay = DEFAULT_PRICE_PER_DAY;
            double pricePerQuery = DEFAULT_PRICE_PER_QUERY;

            price = daysAccouned * pricePerDay + queriesAccounted * pricePerQuery;
        }

    }
}