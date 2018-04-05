using System.Collections.Generic;
using System.Linq;

namespace HarryPotterCatter
{
    public class Basket
    {
        readonly Dictionary<int, decimal> _discounts =
        new Dictionary<int, decimal>
                {
                    {1, 8M},
                    {2, (8*2)*.95M},
                    {3, (8*3)*.90M},
                    {4, (8*4)*.80M},
                    {5, (8*5)*.75M}};

        private readonly List<IBasketItem> _items = new List<IBasketItem>();

        public void Add(IBasketItem basketItem)
        {
            _items.Add(basketItem);
        }

        public decimal CheckOut()
        {
            var distinctItems = _items.Distinct().ToList();
            var nonDiscountedBooks = _items.Count() - distinctItems.Count();
            var discountValue = CalculateDiscount(distinctItems);
            return nonDiscountedBooks * 8 + discountValue;
        }

        private decimal CalculateDiscount(IEnumerable<IBasketItem> distinctItems)
        {
            return _discounts[distinctItems.Count()];
        }
    }
}
