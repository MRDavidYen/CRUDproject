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
    public static class UpdateRepository
    {
        public static UpdateViewModel GetData(int OrderID)
        {
            DynamicParameters Param = new DynamicParameters();
            Param.Add("OrderID", OrderID);

            string CommandString = @"
            select Orders.OrderID,OrderDate OrderDays,RequiredDate RequiredDays,Customers.CompanyName CustomerName,Customers.CustomerID,Customers.ContactName CustomerContractName from Customers
            left join Orders on Orders.CustomerID = Customers.CustomerID
            WHERE Orders.OrderID = @OrderID";

            using (SqlConnection conn = new SqlConnection(settings.DBConn.Northwind.ConnectionString))
            {
                conn.Open();
                return conn.Query<UpdateViewModel>(CommandString, Param).FirstOrDefault();
            }
        }
        public static int UpdateData(UpdateViewModel Model)
        {
            DynamicParameters Param = new DynamicParameters();
            Param.Add("OrderID", Model.OrderID);
            Param.Add("CustomerID", Model.CustomerID);
            Param.Add("OrderDate", Model.OrderDate);
            Param.Add("RequestDate", Model.RequiredDate);
            Param.Add("CustomerName", Model.CustomerName);
            Param.Add("CustomerContractName", Model.CustomerContractName);

            string CommandString = @"
            UPDATE Orders SET OrderDate = @OrderDate,RequiredDate = @RequestDate WHERE OrderID = @OrderID
            UPDATE Customers SET CompanyName = @CustomerName,ContactName = @CustomerContractName WHERE CustomerID = @CustomerID";

            using (SqlConnection conn = new SqlConnection(settings.DBConn.Northwind.ConnectionString))
            {
                conn.Open();
                return conn.Execute(CommandString, Param);
            }
        }
    }
}