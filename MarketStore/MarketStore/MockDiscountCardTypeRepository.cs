using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class MockDiscountCardTypeRepository : IDiscountCardTypeRepository
    {
            public IEnumerable<DiscountCardType> GetAllCardTypes =>
            new List<DiscountCardType>()
                {
                    new DiscountCardType(){ CardType = CardTypes.Bronze},
                    new DiscountCardType(){ CardType = CardTypes.Silver},
                    new DiscountCardType(){ CardType = CardTypes.Gold}
                };
    }
}
