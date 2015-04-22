using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//download allemaal http://www.oracle.com/technetwork/topics/dotnet/index-085163.html
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DataLibrary
{
    public class DatabaseConnection
    {
        //FIELDS
        private OracleConnection con;

        public OracleConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        //CONSTRUCTOR
        public DatabaseConnection()
        {
        }
        /// <summary>
        /// Connect with the database.
        /// </summary>
        public void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "Data Source =fhictora01.fhict.local:1521/fhictora; User Id=dbi288322; Password=ATh2UZf41A;";          
            //con.ConnectionString = "Data Source =PTS23-DBServer/xe; User ID=SYSTEM; Password=system;";
            con.Open();
            Console.WriteLine("Connected to Oracle" + con.ServerVersion);
        }
        /// <summary>
        /// Close the database connection.
        /// </summary>
        public void Close()
        {
            con.Close();
            con.Dispose();
        }

    }
}
