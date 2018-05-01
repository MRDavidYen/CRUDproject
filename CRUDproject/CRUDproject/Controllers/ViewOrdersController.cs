using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDproject.ViewModels;
using CRUDproject.Models;

namespace CRUDproject.Controllers
{
    public class ViewOrdersController : Controller
    {
        // GET: ViewOrders
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ViewOrder()
        {
            ViewOrdersViewModel model = new ViewOrdersViewModel();
            model.OrderList = ViewOrdersModel.GetOrdersView("19960101", "19970101");
            return View(model);
        }
        [HttpPost]
        public ActionResult ViewOrdersPost()
        {

            return View();
        }
    }
}