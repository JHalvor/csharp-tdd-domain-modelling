using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class SupermarketTest
    {
        [TestCase("Apple", 12, true)]
        [TestCase("Banana", 5, true)]
        [TestCase("Coffee", 8, true)]
        public void TestAddNewProductInBasket(string product, int price, bool expectedBasketAddResult)
        {
            //Arrange
            Supermarket customer = new Supermarket();

            //Act
            bool actualBasketAddResult = customer.Add(product, price);

            //Assert
            Assert.That(expectedBasketAddResult, Is.EqualTo(actualBasketAddResult));
        }

        [TestCase("Apple", 12, false)]
        [TestCase("Banana", 5, false)]
        [TestCase("Coffee", 8, false)]
        public void TestAddExistingProductInBasket(string product, int price, bool expectedBasketAddResult)
        {
            //Arrange
            Supermarket customer = new Supermarket();
            customer.Add(product, price);

            //Act
            bool actualBasketAddResult = customer.Add(product, price);

            //Assert
            Assert.That(expectedBasketAddResult, Is.EqualTo(actualBasketAddResult));
        }
    }
}