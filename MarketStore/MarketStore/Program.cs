using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerData = new MockCustomerRepository();
            int i = 0;
            foreach(var customer in customerData.GetAllCustomers)
            {
                i++;
                Console.WriteLine($"{i}. {customer.CardInfo.CardType}:");
                Console.WriteLine($"   Mock data: turnover {customer.Turnover.ToString("C0")}, purchase value: {customer.PurchasePrice.ToString("C0")};");
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine($" \u03BF Purchase value: {customer.PurchasePrice.ToString("C2")}");
                Console.WriteLine($" \u03BF Discount rate:  {customer.DiscountRateInPercentage:N1}%");
                Console.WriteLine($" \u03BF Discount:       {customer.TotalDiscount.ToString("C2")}");
                Console.WriteLine($" \u03BF Total:          {customer.TotalPriceWithDiscount.ToString("C2") }");
                Console.WriteLine();
            }

        }
    }
}
