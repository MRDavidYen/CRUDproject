using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDproject.ViewModels
{
    public class ViewOrdersViewModel
    {
        public List<OrdersList> OrderList { get; set; }
    }
    public class OrdersList
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContractName { get; set; }
        public string EmployeeName { get; set; }
    }
}