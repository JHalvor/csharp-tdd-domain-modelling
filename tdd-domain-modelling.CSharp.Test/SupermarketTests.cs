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
    }
}