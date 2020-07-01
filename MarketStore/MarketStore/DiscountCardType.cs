using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class DiscountCardType
    {
        public CardTypes CardType { get; set; }
        public double InitialDiscountRate
        {
            get
            {
                switch (CardType)
                {
                    case CardTypes.Bronze:
                        return 0;
                    case CardTypes.Silver:
                        return 0.02;
                    case CardTypes.Gold:
                        return 0.02;
                    default:
                        return 0;
                }
            }
        }

        public double DiscountRate(double Turnover)
        {
            switch (CardType)
            {
                case CardTypes.Bronze:
                    if(Turnover <= 100 & Turnover >= 300)
                    { return 0.01; }
                    else if (Turnover > 300)
                    { return 0.025; }
                    else return InitialDiscountRate;
                case CardTypes.Silver:
                    if (Turnover > 300)
                    { return 0.035; }
                    else return InitialDiscountRate;
                case CardTypes.Gold:
                    return System.Math.Min(0.10, InitialDiscountRate + 0.01*Turnover/100);
                default:
                    return 0;
            }
        }

        public double DiscountRateInPercentage(double Turnover)
        {
            return 100 * DiscountRate(Turnover);
        }

        public double TotalDiscount(double purchasePrice, double Turnover)
        {
            return purchasePrice * DiscountRate(Turnover);
        }

        public double TotalPriceWithDiscount(double purchasePrice, double Turnover)
        {
            return purchasePrice - TotalDiscount(purchasePrice, Turnover);
        }

    }
}
