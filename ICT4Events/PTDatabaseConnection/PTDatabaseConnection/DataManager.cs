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
        List<string> result;
        public DataManager()
        {
        }
        public void XCTNonQuery(string query)
        {
            connect = new DatabaseConnection();
            connect.Connect();
            OracleCommand cmd = new OracleCommand(query);
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connect.Close();
            }
        }
        public List<string> XCTReader(string query)
        {
            result = new List<string>();
            connect = new DatabaseConnection();
            connect.Connect();
            OracleCommand cmd = new OracleCommand(query);
            OracleDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    result.Add(reader.ToString());
                }
            }
            finally
            {
                connect.Close();
            }
            return result;
        }
        public List<string> GetAccount(int ID)
        {
            string query = String.Format("SELECT * FROM ACCOUNT WHERE USERNAME = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public List<string> GetAccount(string naam)
        {
            string query = String.Format("SELECT * FROM ACCOUNT WHERE USERNAME = {0}",naam);
            result = XCTReader(query);
            return result;
        }
        public void SetAccount(List<string> account)
        {
            string date = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", account[8]);
            string query = String.Format("INSERT INTO ACCOUNT VALUES({0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10})"
                ,account[0],account[1],account[2],account[3]
                ,account[4],account[5],account[6],account[7]
                ,date,account[9],account[10]);
            XCTNonQuery(query);
        }
        public List<string> GetEvent(string ID)
        {
            string query = String.Format("SELECT * FROM EVENT WHERE EVENTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetEvent(List<string> eventinfo)
        {
            string dateStart = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", eventinfo[2]);
            string dateEnd = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", eventinfo[3]);
            string query = String.Format("INSERT INTO EVENT VALUES({0}{1}{2}{3}{4}{5})"
                , eventinfo[0], eventinfo[1], dateStart, dateEnd
                , eventinfo[4], eventinfo[5]);
            XCTNonQuery(query);
        }
        public List<string> GetItem(string ID)
        {
            string query = String.Format("SELECT * FROM ITEM WHERE ITEMID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetItem(List<string> item)
        {
           string query = String.Format("INSERT INTO ITEM VALUES({0}{1}{2}{3}{4})"
                , item[0], item[1], item[2], item[3]
                , item[4]);
            XCTNonQuery(query);
        }
        public List<string> GetReservation(string ID)
        {
            string query = String.Format("SELECT * FROM RESERVATION R,GUESTRESERVATION G WHERE R.RESERVATIONID = G.RESERVATIONID AND G.GUESTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetReservation(List<string> reservation,string ID)
        {
            string dateStart = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", reservation[2]);
            string dateEnd = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", reservation[3]);
            string query = String.Format("INSERT INTO RESERVATION VALUES({0}{1}{2}{3}{4}{5})"
                , reservation[0], reservation[1], dateStart, dateEnd
                , reservation[4], reservation[5]);
            XCTNonQuery(query);
            query = String.Format("INSERT INTO GUESTRESERVATION VALUES({0}{1}",reservation[0],ID);
            XCTNonQuery(query);
        }
        public List<string> GetPresence(string ID)
        {
            string query = String.Format("SELECT ISPRESENT FROM GUEST WHERE GUESTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetPresence(string ID)
        {
            string query = String.Format("INSERT INTO GUEST (ISPRESENT) VALUES({0}",ID);
            XCTNonQuery(query);
        }
        public List<string> GetPost(string ID)
        {
            string query = String.Format("SELECT * FROM FILETABLE F, COMMENTTABLE C WHERE F.FILEID = C.FILEID AND F.FILEID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetPost()
        {

        }
    }
}
