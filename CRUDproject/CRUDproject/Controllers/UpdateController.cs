using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDproject.Models;
using CRUDproject.ViewModels;

namespace CRUDproject.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        [HttpGet]
        public ActionResult UpdateOrders(int OrderID)
        {
            UpdateViewModel view = new UpdateViewModel();
            view = UpdateModels.GetOrderData(OrderID);

            return View(view);
        }
        [HttpPost]
        public ActionResult UpdateOrders(UpdateViewModel Model)
        {
            int Result = UpdateModels.UpdateOrderData(Model);
            if(Result > 0)
            {
                return RedirectToAction("ViewOrder","ViewOrders");
            }
            return View(Model);
        }
    }
}