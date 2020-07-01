using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public interface IDiscountCardTypeRepository
    {
        public IEnumerable<DiscountCardType> GetAllCardTypes { get; }
    }
}
