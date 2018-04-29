using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CRUDproject.Models
{
    public class settings
    {
        public class DBConn
        {
            public static ConnectionStringSettings Northwind = ConfigurationManager.ConnectionStrings["NorthWind"];
        }
    }

}