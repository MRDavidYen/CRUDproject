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
        public ActionResult ViewOrder(string StartDate,string EndDate)
        {
            ViewOrdersViewModel model = new ViewOrdersViewModel();
            if(!string.IsNullOrEmpty(StartDate) && !string.IsNullOrEmpty(EndDate))
            {
                model.OrderList = ViewOrdersModel.GetOrdersView(StartDate,EndDate);
            }
            if(model.OrderList !=null && model.OrderList.Any())
            {
                return View(model);
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult ViewOrder(ViewOrdersViewModel view)
        {
            view.OrderList = ViewOrdersModel.GetOrdersView(view.StartDate, view.EndDate);
            return View(view);
        }
    }
}