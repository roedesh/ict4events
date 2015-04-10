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
    class DataManager
    {
        DatabaseConnection connect;
        string result;
        public DataManager()
        {
        }
        public string XCTNonQuery(string query)
        {
            connect = new DatabaseConnection();
            connect.Connect();
            OracleCommand cmd = new OracleCommand(query);
            OracleDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    result += reader.ToString();
                }
            }
            finally
            {

                connect.Close();
            }
            return result;
        }
        public string GetAccount(int ID)
        {
            string query = String.Format("SELECT * FROM ACCOUNT WHERE Username = {0}", ID);
            result = XCTNonQuery(query);
            return result;
        }
        public string GetAccount(string naam)
        {
            string query = String.Format("SELECT * FROM ACCOUNT WHERE Username = {0}",naam);
            result = XCTNonQuery(query);
            return result;
        }
        public void SetAcount(string account)
        {
            gsfag
            string query = String.Format("INSERT INTO ACCOUNT VALUES({0})",account);
        }
        public string GetEvent(string ID)
        {
            string query = String.Format("SELECT * FROM EVENT WHERE EVENTID = {0}", ID);
            result = XCTNonQuery(query);
            return result;
        }
        public void SetEvent()
        {

        }
        public string GetItem(string ID)
        {
            string query = String.Format("SELECT * FROM ITEM WHERE ITEMID = {0}", ID);
            result = XCTNonQuery(query);
            return result;
        }
        public void SetItem()
        {
        }
        public string GetReservation(string ID)
        {
            string query = String.Format("SELECT * FROM RESERVATION WHERE RESERVATIONID = {0}", ID);
            result = XCTNonQuery(query);
            return result;
        }
        public void SetReservation()
        {

        }
        public string GetPresence(string ID)
        {
            string query = String.Format("SELECT ISPRESENT FROM GUEST WHERE GUESTID = {0}", ID);
            result = XCTNonQuery(query);
            return result;
        }
        public void SetPresence()
        {

        }
        public void SetReserved()
        {

        }
        public string GetPost()
        {
            string query = String.Format("SELECT * FROM ACCOUNT WHERE Username = {0}", naam);
            result = XCTNonQuery(query);
            return result;
        }
        public void SetPost()
        {

        }
    }
}
