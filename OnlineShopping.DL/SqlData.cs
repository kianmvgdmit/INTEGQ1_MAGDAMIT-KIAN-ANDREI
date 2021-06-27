using System.Data.Common;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.DL;

namespace OnlineShopping.DL
{
    class SqlData
    {
        static string connectionString = "Data Source=LAPTOP-JO3M7SI3;Initial Catalog = OnlineShopping; Integrated Security = True";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
