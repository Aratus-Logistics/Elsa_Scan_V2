using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Elsa_Scan_V2.DAL.Clients;
using Elsa_Scan_V2.DAL.Models;

namespace DatabaseTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var _resource = new ResourceModel("Location", "E5400A00");
            var _queryString = "Select * from SalesLT.Product";

            var _data = SqlDbClient.GetResourceData(_queryString, _resource);

            Console.WriteLine(_data.Status);
            Console.WriteLine(_data.Message);
        }
    }
}
