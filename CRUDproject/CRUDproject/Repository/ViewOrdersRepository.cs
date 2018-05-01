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
    public static class ViewOrdersRepository
    {
        public static List<OrdersList> GetList(string StartDate,string EndDate)
        {
            DynamicParameters Param = new DynamicParameters();
            Param.Add("@StartDate", StartDate);
            Param.Add("@EndDate", EndDate);

            string CommandString = @"
            select Orders.OrderID,OrderDate,RequiredDate,Customers.CompanyName CustomerName,Customers.ContactName CustomerContractName,Employees.FirstName  + ' '+ Employees.LastName as EmployeesName from Customers
            left join Orders on Orders.CustomerID = Customers.CustomerID
            join Employees on Employees.EmployeeID = Orders.EmployeeID
            WHERE OrderDate between @StartDate and @EndDate   
            order by Orders.OrderDate";

            using (SqlConnection conn = new SqlConnection(settings.DBConn.Northwind.ConnectionString))
            {
                conn.Open();
                return conn.Query<OrdersList>(CommandString, Param).ToList();
            }

        }
    }
}