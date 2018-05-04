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
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        
    }
}