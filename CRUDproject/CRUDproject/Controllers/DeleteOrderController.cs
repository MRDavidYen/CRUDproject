using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDproject.Models;
namespace CRUDproject.Controllers
{
    public class DeleteOrderController : Controller
    {
        // GET: DeleteOrder
        [HttpPost]
        public JsonResult DeleteItem(int OrderID)
        {
            bool Result = DeleteOrderModel.DeleteOrder(OrderID);
            if (Result)
            {
                return Json(true);
            }
            return Json(false);
        }
    }
}