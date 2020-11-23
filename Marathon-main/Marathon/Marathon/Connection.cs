using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Marathon
{
    class Connection
    {
        internal static string ConnectionStr = @"Data Source=MSSQLSTUD;Initial Catalog=Marathon_Revkin;User ID=user;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal static SqlConnection connection = new SqlConnection(ConnectionStr);
        internal static string userLogin = "";

    }
}
