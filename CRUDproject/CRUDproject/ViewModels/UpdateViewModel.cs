using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDproject.ViewModels
{
    public class UpdateViewModel
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContractName { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public DateTime OrderDays { get; set;}
        public DateTime RequiredDays { get; set; }
        
    }
}