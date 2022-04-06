using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Repository
{
    public class BuyCardTranferMoney
    {

        public static void TranferMoney(ApplicationUser owner,ApplicationUser buyer,ApplicationUser admin,int price)
        {
            buyer.Balance -= price;
            owner.Balance += price - price * 0.1;
            admin.Balance += price * 0.1;
        }
    }
}