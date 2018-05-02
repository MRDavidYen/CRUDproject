using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDproject.Repository;
using CRUDproject.ViewModels;

namespace CRUDproject.Models
{
    public static class DeleteOrderModel
    {
         public static bool DeleteOrder(int OrderID)
        {
            try
            {
                int Result = DeleteOrderRepository.DeleteOrder(OrderID);
                if(Result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}