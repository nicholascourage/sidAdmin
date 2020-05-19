using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web;
using System.Text;
using System.Threading.Tasks;
namespace sidAdmin.Models
{
    public class SalesOrderDetail
    {
        public int Sr { get; set; }
        public string OrderTrackNumber { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string SpecialOffer { get; set; }
        public double UnitPrice { get; set; }
        public double UnitPriceDiscount { get; set; }

    }

    public class sidApplicationStaff {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string accessTypeDescription { get; set; }



    }
}