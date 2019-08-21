using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleFluentApp
{
    public static class CheckOut
    {
        const string Apple = "Apple";
        const string Orange = "Orange";
        const int ApplePrice = 60;
        const int OrangePrice = 25;


        public static decimal CheckOutShoppingList(List<string> shoppingCart)
        {
            decimal totalPrice = 0;
            int AppleSpecialOffer = 0;
            int OrangeSpecialOffer = 0;


            foreach (string item in shoppingCart)
            {
                if (item.Equals(Apple))
                {
                    AppleSpecialOffer++;
                    if (AppleSpecialOffer == 2)
                    {
                        AppleSpecialOffer = 0;
                    }
                    else
                    {
                        totalPrice += ApplePrice;
                    }

                }

                if (item.Equals(Orange))
                {
                    OrangeSpecialOffer++;
                    if (OrangeSpecialOffer == 3)
                    {
                        OrangeSpecialOffer = 0;
                    }
                    else
                    {
                        totalPrice += OrangePrice;
                    }

                }

            }
            return totalPrice;

        }
    }
}

