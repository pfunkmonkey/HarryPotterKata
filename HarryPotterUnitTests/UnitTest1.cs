using System.Collections.Generic;
using HarryPotterCatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotterUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        private List<Book> _books;

        [TestInitialize]
        public void TestInitialize()
        {
            _books = new List<Book>
            {
                new Book {Isbn = 1,  Name = "harry potter"}
                ,
                new Book {Isbn = 2, Name = "DuranDuran"}
                ,
                new Book {Isbn = 3, Name = "Something"}
                ,
                new Book {Isbn = 4,  Name = "Crap"}
                ,
                new Book {Isbn = 5,  Name = "SomethingElse"},
            };
        }

        [TestMethod]
        public void Buy1Book_PriceWillBeEightDollars()
        {
            var basket = new Basket();
            basket.Add(_books[1]);

            var totalCost = basket.CheckOut();

            Assert.IsTrue(totalCost == 8);
        }

        [TestMethod]
        public void Buy2DifferentBooks_YouWIllGetA5percentDiscount()
        {
            var basket = new Basket();
            basket.Add(_books[1]);
            basket.Add(_books[2]);

            var totalCost = basket.CheckOut();
            Assert.IsTrue(totalCost == 15.20M);
        }

        [TestMethod]
        public void Buy3DifferentBooks_YouWIllGetA10percentDiscount()
        {
            var basket = new Basket();
            basket.Add(_books[4]);
            basket.Add(_books[1]);
            basket.Add(_books[2]);

            var totalCost = basket.CheckOut();
            Assert.IsTrue(totalCost == 21.6M);
        }

        [TestMethod]
        public void Buy4DifferentBooks_YouWIllGetA20percentDiscount()
        {
            var basket = new Basket();
            basket.Add(_books[4]);
            basket.Add(_books[3]);
            basket.Add(_books[1]);
            basket.Add(_books[2]);

            var totalCost = basket.CheckOut();
            Assert.IsTrue(totalCost == 25.6M);
        }

        [TestMethod]
        public void Buy5DifferentBooks_YouWIllGetA20percentDiscount()
        {
            var basket = new Basket();
            basket.Add(_books[4]);
            basket.Add(_books[3]);
            basket.Add(_books[1]);
            basket.Add(_books[2]);
            basket.Add(_books[0]);
            var totalCost = basket.CheckOut();
            Assert.IsTrue(totalCost == 30);
        }

        [TestMethod]
        public void BuyThreeBooks_2DifferentTitles_10PercentDiscountBut4thWillBe8Euro()
        {
            var basket = new Basket();
            basket.Add(_books[4]);
            basket.Add(_books[1]);
            basket.Add(_books[1]);
            var totalCost = basket.CheckOut();
            Assert.IsTrue(totalCost == 23.2M);
        }

        [TestMethod]
        public void BuyFiveBooks_2DifferentTitles_10PercentDiscountBut4thWillBe8Euro()
        {
            var basket = new Basket();
            basket.Add(_books[4]);
            basket.Add(_books[1]);
            basket.Add(_books[1]);
            var totalCost = basket.CheckOut();
            Assert.IsTrue(totalCost == 23.2M);
        }
    }
}
