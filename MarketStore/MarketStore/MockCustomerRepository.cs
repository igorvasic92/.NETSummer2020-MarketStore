using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketStore
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private readonly IDiscountCardTypeRepository _discountCardRepository = new MockDiscountCardTypeRepository();

        public IEnumerable<CustomerCard> GetAllCustomers =>
            new List<CustomerCard>()
                {
                    new CustomerCard(){CustomerCardId=1, FirstName = "John", LastName="Lennon", CardInfo= _discountCardRepository.GetAllCardTypes.ToList()[0], Turnover = 0, PurchasePrice=150},
                    new CustomerCard(){CustomerCardId=2, FirstName = "Lewis", LastName="Hamilton", CardInfo= _discountCardRepository.GetAllCardTypes.ToList()[1], Turnover = 600, PurchasePrice=850},
                    new CustomerCard(){CustomerCardId=3, FirstName = "Dennis", LastName="Rodman", CardInfo= _discountCardRepository.GetAllCardTypes.ToList()[2], Turnover = 1500, PurchasePrice=1300}/*,
                    new CustomerCard(){CustomerCardId=4, FirstName = "Dennis", LastName="The Menace", CardInfo= _discountCardRepository.GetAllCardTypes.ToList()[1], Turnover = 25000, PurchasePrice=820},
                    new CustomerCard(){CustomerCardId=5, FirstName = "Artan", LastName="Lili", CardInfo= _discountCardRepository.GetAllCardTypes.ToList()[2], Turnover = 820, PurchasePrice=500}*/
                };

        public CustomerCard GetCustomerById( int id)
        {
            return GetAllCustomers.Where(c => c.CustomerCardId == id).FirstOrDefault();
        }
    }
}
