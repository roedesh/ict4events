using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//download allemaal http://www.oracle.com/technetwork/topics/dotnet/index-085163.html
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
            //connect.ConnectionString = "Data source=localhost:1521/xe;User ID=system;Password=12345;";   <- local connectionstring
            connect.ConnectionString = "Data Source =fhictora01.fhict.local:1521/fhictora; User Id=dbi324352; Password=F05Qo8Sfew; ";
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
