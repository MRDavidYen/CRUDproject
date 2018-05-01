using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDproject.Repository;
using CRUDproject.ViewModels;

namespace CRUDproject.Models
{

    public static class ViewOrdersModel
    {
        public static List<OrdersList> GetOrdersView(string StartDate, string EndDate)
        {
            List<OrdersList> ReturnData = new List<OrdersList>();
            ReturnData = ViewOrdersRepository.GetList(StartDate,EndDate);
            return ReturnData;
        }
    }
}