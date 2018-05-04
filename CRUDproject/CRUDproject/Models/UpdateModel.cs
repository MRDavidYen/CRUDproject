using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDproject.Repository;
using CRUDproject.ViewModels;

namespace CRUDproject.Models
{
    public static class UpdateModels
    {
        public static UpdateViewModel GetOrderData(int OrderID)
        {
            try
            {
                return UpdateRepository.GetData(OrderID);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static int UpdateOrderData(UpdateViewModel Model)
        {
            try
            {
                return UpdateRepository.UpdateData(Model);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}