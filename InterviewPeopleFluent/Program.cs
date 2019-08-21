using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFluentApp
{
    class PeopleFluentApp
    {

        static void Main(string[] args)
        {
            string[] shoppingList = { "Apple", "Apple", "Orange", "Orange", "Apple", "Orange" };
            var price = CheckOut.CheckOutShoppingList(shoppingList.ToList<string>());
            Console.WriteLine("total price is " + price.ToString() + " p");
            Console.ReadLine();
        }
    }
}

