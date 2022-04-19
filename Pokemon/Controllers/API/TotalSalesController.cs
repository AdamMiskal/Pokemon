using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pokemon.Controllers.API
{
    public class TotalSalesController : ApiController
    {

        ApplicationDbContext db;

        public TotalSalesController()
        {
            db = new ApplicationDbContext();
        }

        public List<object> GetAllSalesStats()
        {
            var totalprice = new List<int>();
            var sales = db.Sales.ToList();
            double totalSales = db.Sales.Count();
            foreach (var sale in sales)
            {
                totalprice.Add(sale.Price);
            }
            double average= totalprice.Average();
            double totalMoneyTranfer = totalprice.Sum();
            double winnings= totalMoneyTranfer * 0.1;
            var obj1 = new { name = "Total Sales", result = totalSales };
            var obj2 = new { name = "Average Price Per Sale", result = average };
            var obj3 = new { name = "Total Money Tranfer", result = totalMoneyTranfer };
            var obj4 = new { name = "Total Company winnings from sales", result = winnings };
            List<object> result = new List<object>() { obj1, obj2, obj3, obj4 };

            return result;
        }


    }
}
