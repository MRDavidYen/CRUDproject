using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;
using CRUDproject.ViewModels;
using CRUDproject.Models;

namespace CRUDproject.Repository
{
    public static class DeleteOrderRepository
    {
        public static int DeleteOrder(int OrderID)
        {
            DynamicParameters Param = new DynamicParameters();
            Param.Add("OrderID", OrderID);

            string CommandString = @"
            DELETE FROM [Order Details]  where OrderID = @OrderID
            DELETE FROM Orders WHERE OrderID = @OrderID";

            using (SqlConnection conn = new SqlConnection(settings.DBConn.Northwind.ConnectionString))
            {
                conn.Open();
                return conn.Execute(CommandString, Param);
            }
        }
    }
}