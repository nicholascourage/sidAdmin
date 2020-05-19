using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web;
using System.Text;
using System.Threading.Tasks;
namespace sidAdmin.Models

{
    public class DataTables
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<SalesOrderDetail> data { get; set; }
    }
}