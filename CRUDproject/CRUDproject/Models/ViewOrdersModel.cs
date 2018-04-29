using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDproject.Repository;

namespace CRUDproject.Models
{

    public class ViewOrdersModel
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContractName { get; set; }
        public string EmployeeName { get; set; }
    }
    public class ViewOrdersFun
    {
        public void GetOrdersView(string StartDate, string EndDate)
        {
            
        }
    }
}