using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//download allemaal http://www.oracle.com/technetwork/topics/dotnet/index-085163.html
using Oracle.DataAccess.Client; 
namespace PTDatabaseConnection
{
    class DatabaseConnection
    {
        OracleConnection connect;
        public DatabaseConnection()
        {
            //
        }
        public void Connect()
        {
            connect = new OracleConnection();
            connect.ConnectionString = "Data Source=<datasource>";
            connect.Open();
            Console.WriteLine("Connected to Oracle" + connect.ServerVersion);
        }

        public void Close()
        {
            connect.Close();
            connect.Dispose();
        }

    }
}
