using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleFluentApp;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckoutTest()
        {
            string[] shoppingList = { "Apple", "Apple", "Orange", "Orange", "Apple", "Orange" };
            var price = CheckOut.CheckOutShoppingList(shoppingList.ToList<string>());
            Assert.AreEqual(170, price);
        }
    }
}
