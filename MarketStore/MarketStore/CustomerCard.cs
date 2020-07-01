using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class CustomerCard
    {
        public int CustomerCardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Turnover { get; set; }
        public DiscountCardType CardInfo { get; set; }
        public double PurchasePrice { get; set; }
        public double DiscountRate => CardInfo.DiscountRate(Turnover);
        public double DiscountRateInPercentage => CardInfo.DiscountRateInPercentage(Turnover);
        public double TotalDiscount => CardInfo.TotalDiscount(PurchasePrice, Turnover);
        public double TotalPriceWithDiscount => CardInfo.TotalPriceWithDiscount(PurchasePrice, Turnover);
    }
}
