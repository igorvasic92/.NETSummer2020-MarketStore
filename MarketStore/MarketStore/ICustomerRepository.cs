using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public interface ICustomerRepository
    {
        public IEnumerable<CustomerCard> GetAllCustomers { get; }
    }
}
