using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ConnectionString
{
    public static class DatabaseConnectionString
    {
        public static void Test()
        {
            SqlConnection connection = new SqlConnection("Server = LAPTOP-F051SPJ3\\SQLEXPRESS; initial Catalog = EgitimKampi501Db; integrated security = true ");

        }
    }
}
