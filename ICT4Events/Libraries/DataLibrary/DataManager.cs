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
    public class DataManager
    {
        DatabaseConnection connect;
        List<Dictionary<string, string>> result;
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
        public List<Dictionary<string, string>> XCTReader(string query)
        {
            result = new List<Dictionary<string, string>>();
            connect = new DatabaseConnection();
            connect.Connect();
            OracleCommand cmd = new OracleCommand(query, connect.Con);
            OracleDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>();
                    for (int f = 0; f < reader.FieldCount; f++)
                    {
                        Console.WriteLine(reader.GetName(f));
                        fields[reader.GetName(f)] = Convert.ToString(reader.GetValue(f));
                    }
                        
                    result.Add(fields);
                }
            }
            catch (OracleException ex)
            {
            
                Console.WriteLine("Exception Source: " + ex.Source);
            }
            finally
            {
                connect.Close();
            }
            return result;
        }
        public List<Dictionary<string, string>> GetGuestAccount(int ID)
        {
            string query = String.Format("SELECT * FROM Account a, Guest g WHERE a.AccountID = g.AccountID AND a.AccountID = '{0}'", ID);
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetGuestAccount(string name)
        {
            string query = String.Format("SELECT * FROM Account a, Guest g WHERE a.AccountID = g.AccountID AND a.Username = '{0}'", name);
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetEmployeeAccount(int ID)
        {
            string query = String.Format("SELECT * FROM ACCOUNT A,EMPLOYEE E WHERE A.ACCOUNTID = E.ACCOUNTID AND A.ACCOUNTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetEmployeeAccount(string name)
        {
            string query = String.Format("SELECT * FROM ACCOUNT A,EMPLOYEE E WHERE A.ACCOUNTID = E.ACCOUNTID AND A.USERNAME = {0}", name);
            result = XCTReader(query);
            return result;
        }
        public void SetGuestAccount(List<string> account, List<string> guest)
        {
            string query = "SELECT MAX(ACCOUNTID) FROM ACCOUNT";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            string date = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", account[8]);
            query = String.Format("INSERT INTO ACCOUNT VALUES({0}{1}{2}{3}{4}{5}{6}{7}{8}{9})"
                , ID, account[1], account[2], account[3]
                , account[4], account[5], account[6], account[7]
                , date, account[9]);
            query = String.Format("INSERT INTO GUEST VALUES({0}{1}{2}{3})"
                , guest[0], guest[1], guest[2], guest[3]);
            XCTNonQuery(query);
        }
        public void SetEmployeeAccount(List<string> account, List<string> employee)
        {
            string query = "SELECT MAX(ACCOUNTID) FROM ACCOUNT";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            string date = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", account[8]);
            query = String.Format("INSERT INTO ACCOUNT VALUES({0}{1}{2}{3}{4}{5}{6}{7}{8}{9})"
                , ID, account[1], account[2], account[3]
                , account[4], account[5], account[6], account[7]
                , date, account[9]);
            XCTNonQuery(query);
            query = String.Format("INSERT INTO GUEST VALUES({0}{1}{2})"
                , employee[0], employee[1], employee[2]);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetAllGuests()
        {
            string query = "SELECT * FROM GUEST";
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetAllEmployees()
        {
            string query = "SELECT * FROM EMPLOYEE";
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetAllEvents()
        {
            string query = "SELECT * FROM EVENT";
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetEvent(string ID)
        {
            string query = String.Format("SELECT * FROM EVENT WHERE EVENTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetEvent(List<string> eventinfo)
        {
            string query = "SELECT MAX(EVENTID) FROM EVENT";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            string dateStart = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", eventinfo[2]);
            string dateEnd = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", eventinfo[3]);
            query = String.Format("INSERT INTO EVENT VALUES({0}{1}{2}{3}{4}{5})"
                , ID, eventinfo[1], dateStart, dateEnd
                , eventinfo[4], eventinfo[5]);
            XCTNonQuery(query);
        }
        public void DeleteGuest(string ID)
        {
            string query = String.Format("DELETE * FROM GUEST G, ACCOUNT A WHERE A.ACCOUNTID = G.ACCOUNTID AND A.ACCOUNTID = {0}", ID);
            XCTNonQuery(query);
        }
        public void DeleteEmployee(string ID)
        {
            string query = String.Format("DELETE * FROM EMPLOYEE G, ACCOUNT A WHERE A.ACCOUNTID = G.ACCOUNTID AND A.ACCOUNTID = {0}", ID);
            XCTNonQuery(query);
        }
        public void DeleteEvent(string ID)
        {
            string query = String.Format("DELETE EVENTID FROM ACCOUNT WHERE EVENTID = {0}", ID);
            XCTNonQuery(query);
            query = String.Format("DELETE * FROM EVENT WHERE EVENTID = {0}", ID);
            XCTNonQuery(query);
        }
        public void UpdateGuest(List<string> guest)
        {
            string query = String.Format("UPDATE GUEST SET GUESTID = {0}, ACCOUNTID = {1}, RFID = {2}, ISPRESENT = {3};"
                , guest[0], guest[1], guest[2], guest[3]);
            XCTNonQuery(query);
        }
        public void UpdateEmployee(List<string> employee)
        {
            string query = String.Format("UPDATE EMPLOYEE SET EMPLOYEEID = {0}, ACCOUNTID = {1}, ROLEID = {2};"
                , employee[0], employee[1], employee[2]);
            XCTNonQuery(query);
        }
        public void UpdateEvent(List<string> eventinfo)
        {
            string dateStart = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", eventinfo[2]);
            string dateEnd = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", eventinfo[3]);
            string query = String.Format("UPDATE EVENT SET EVENTID = {0}, LOCATION = {1}, STARTDATE = {2}, ENDDATE = {3}, DESCRIPTION = {4}, ADMISSIONFEE = {5};"
                , eventinfo[0], eventinfo[1], dateStart, dateEnd, eventinfo[4], eventinfo[5]);
            XCTNonQuery(query);
        }
        public void UpdateAccount(List<string> account)
        {
            string date = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", account[8]);
            string query = String.Format("UPDATE  ACCOUNT SET ACCOUNTID = {0}, EVENTID = {1}, USERNAME = {2}, PASSWORD = {3}, FULLNAME = {4}, ADRESS = {5}, CITY = {6}, POSTALCODE = {7}, DATEOFBIRTH = {8}, EMAIL = {9}, PHONENUMBER = {10}"
                , account[0], account[1], account[2], account[3]
                , account[4], account[5], account[6], account[7]
                , date, account[9]);
            XCTNonQuery(query);
        }
        public void UpdateLocation(List<string> location)
        {
            string query = String.Format("UPDATE LOCATIONTYPE LOCATIONTYPEID = {0}, NAME = {1}, DESCRIPTION = {2}, PRICE = {3}"
                , location[0], location[1], location[2], location[3]);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetItem(string ID)
        {
            string query = String.Format("SELECT * FROM ITEM WHERE ITEMID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetItem(List<string> item)
        {
            string query = "SELECT MAX(ITEMID) FROM ITEM";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            query = String.Format("INSERT INTO ITEM VALUES({0}{1}{2}{3}{4})"
                , ID, item[1], item[2], item[3]
                , item[4]);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetReservation(string ID)
        {
            string query = String.Format("SELECT * FROM RESERVATION R,GUESTRESERVATION G WHERE R.RESERVATIONID = G.RESERVATIONID AND G.GUESTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetReservation(List<string> reservation)
        {
            string query = "SELECT MAX(RESERVATIONID) FROM RESERVATION";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            string dateStart = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", reservation[2]);
            string dateEnd = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", reservation[3]);
            query = String.Format("INSERT INTO RESERVATION VALUES({0}{1}{2}{3}{4}{5})"
                , ID, reservation[1], dateStart, dateEnd
                , reservation[4], reservation[5]);
            XCTNonQuery(query);
        }
        public void SetGuestReservation(string RID, string PID)
        {
            string query = "SELECT MAX(GUESTRESERVATIONID) FROM GUESTRESERVATION";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            query = String.Format("INSERT INTO GUESTRESERVATION VALUES({0}{1}{2})", ID, RID, PID);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetPresence(string ID)
        {
            string query = String.Format("SELECT ISPRESENT FROM GUEST WHERE GUESTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void SetPresence(string Pvalue, string ID)
        {
            string query = String.Format("INSERT INTO GUEST (ISPRESENT) VALUES({0}) WHERE ACCOUNTID = {1}", Pvalue, ID);
            XCTNonQuery(query);
        }
        public void SetFile(List<string> file)
        {
            string query = "SELECT MAX(FILEID) FROM FILETABLE";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            query = String.Format("INSERT INTO FILETABLE VALUES({0}{1}{2}{3}{4}{5}{6}{7})"
                , ID, file[1], file[2], file[3]
                , file[4], file[5], file[6], file[7]);
            XCTNonQuery(query);
        }
        public void SetComment(List<string> comment)
        {
            string query = "SELECT MAX(COMMENTID) FROM COMMENT";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            query = String.Format("INSERT INTO COMMENTTABLE VALUES({0}{1}{2}{3}{4}{5}{6}{7}{8})"
                , ID, comment[1], comment[2], comment[3]
                , comment[4], comment[5], comment[6], comment[7]
                , comment[8]);
            XCTNonQuery(query);
        }
        public void SetLikeOrFlag(List<string> likeorflag)
        {
            string query = "SELECT MAX(LIKEFLAGID) FROM LIKEORFLAG";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            query = String.Format("INSERT INTO LIKEORFLAG VALUES({0}{1}{2}{3}{4}{5})"
                , ID, likeorflag[1], likeorflag[2], likeorflag[3]
                , likeorflag[4], likeorflag[5]);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetFile(string ID)
        {
            string query = String.Format("SELECT * FROM FILETABLE WHERE FILEID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetComment(string ID)
        {
            string query = String.Format("SELECT * FROM COMMENTTABLE WHERE COMMENTID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetFlagOrLike(string ID)
        {
            string query = String.Format("SELECT * FROM LIKEORFLAG WHERE LIKEFLAGID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void UpdateFile(List<string> file)
        {
            string query = String.Format("UPDATE FILETABLE SET FILEID = {0}, ACCOUNTID = {1}, CATEGORYID = {2}, DATETIMEFILE = {3}, TITEL = {4}, FILEPATH = {5}, NUMBEROFLIKES = {6}, NUMBEROFFLAGS = {7}"
                , file[0], file[1], file[2], file[3]
                , file[4], file[5], file[6], file[7]);
            XCTNonQuery(query);
        }
        public void UpdateComment(List<string> file)
        {
            string query = String.Format("UPDATE COMMENTTABLE SET COMMENTID = {0}, FILEID = {1}, ACCOUNTID = {2}, COMMENTRECU = {3}, DATETIMECOMMENT = {4}, TITEL = {5}, MESSAGE = {6}, NUMBEROFLIKES = {7}, NUMBEROFFLAGS = {8}"
                , file[0], file[1], file[2], file[3]
                , file[4], file[5], file[6], file[7]);
            XCTNonQuery(query);
        }
        public void DeleteFile(string ID)
        {
            string query = String.Format("DELETE * FROM FILETABLE WHERE FILEID = {0}", ID);
            XCTNonQuery(query);
            query = String.Format("DELETE * FROM COMMENTTABLE WHERE FILEID = {0}", ID);
            XCTNonQuery(query);
        }
        public void DeleteComment(string ID)
        {
            string query = String.Format("DELETE * FROM COMMENTTABLE WHERE COMMENTID = {0}", ID);
            XCTNonQuery(query);
        }
        public void DeleteFlagLike(string ID)
        {
            string query = String.Format("DELETE * FROM LIKEORFLAG WHERE LIKEFLAGID = {0}", ID);
            XCTNonQuery(query);
        }
        public void SetCategory(List<string> category)
        {
            string query = "SELECT MAX(CATEGORYID) FROM CATEGORY";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            query = String.Format("INSERT INTO CATEGORY VALUES({0}{1}{2})"
                , ID, category[1], category[2]);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetCategory(string ID)
        {
            string query = String.Format("SELECT * FROM CATEGORY WHERE CATEGORYID = {1}", ID);
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetAllCategorys()
        {
            string query = String.Format("SELECT * FROM CATEGORY");
            result = XCTReader(query);
            return result;
        }
        public void UpdateCategory(List<string> category)
        {
            string query = String.Format("UPDATE CATEGORY SET CATEGORYID = {0}, CATEGORYPARENT = {1}, NAME = {2})"
                , category[0], category[1], category[2]);
            XCTNonQuery(query);
        }
        public void DeleteReservation(string ID)
        {
            string query = String.Format("DELETE * FROM RESERVATION WHERE RESERVATIONID = {0}", ID);
            XCTNonQuery(query);
            query = String.Format("DELETE * FROM GUESTRESERVATION WHERE RESERVATIONID = {0}", ID);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetINCReservation(string ID)
        {
            string query = String.Format("SELECT * FROM RESERVATION R, GUESTRESERVATION GR, GUEST G, LOCATION L WHERE R.RESERVATIONID = GR.RESERVATIONID AND GR.GUESTID = G.GUESTID AND R.RESERVATIONID = {0}");
            result = XCTReader(query);
            return result;
        }
        public List<Dictionary<string, string>> GetAllPresentGuests()
        {
            string query = "SELECT * FROM GUEST WHERE ISPRESENT = 'Y'";
            result = XCTReader(query);
            return result;
        }
        public void UpdateItem(List<string> item)
        {
            string query = String.Format("UPDATE ITEM SET ITEMID = {0}, NAME = {1}, TYPEITEM = {2}, STOCK = {3}, PRICE = {4})"
                , item[0], item[1], item[2], item[3]
                , item[4]);
            XCTNonQuery(query);
        }
        public void SetRental(List<string> rental)
        {
            string dateStart = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", rental[2]);
            string dateEnd = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", rental[3]);
            string query = String.Format("INSERT INTO RENTAL VALUES({0}{1}{2}{3}{4})"
                , rental[0], rental[1], dateStart, dateEnd
                , rental[4]);
            XCTNonQuery(query);
        }
        public List<Dictionary<string, string>> GetRental(string ID)
        {
            string query = String.Format("SELECT * FROM RENTAL WHERE ID = {0}", ID);
            result = XCTReader(query);
            return result;
        }
        public void UpdateRental(List<string> rental)
        {
            string dateStart = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", rental[2]);
            string dateEnd = String.Format("TO_DATE('{0}', 'yyyy/mm/dd hh24:mi:ss')", rental[3]);
            string query = String.Format("UPDATE RENTAL SET RENTALID = {0}, GUESTID = {1}, STARTDATE = {2}, ENDDATE = {3}, TOTALAMOUNT = {4})"
                , rental[0], rental[1], dateStart, dateEnd
                , rental[4]);
            XCTNonQuery(query);
        }
        public void DeleteRental(string ID)
        {
            string query = String.Format("DELETE * FROM RENTAL WHERE RENTALID = {0}", ID);
            XCTNonQuery(query);
        }
        public void DeleteItemRental(string ID)
        {
            string query = String.Format("DELETE * FROM ITEMRENTAL WHERE ITEMRENTALID = {0}", ID);
            XCTNonQuery(query);
        }
        public void DeleteItem(string ID)
        {
            string query = String.Format("DELETE * FROM ITEM WHERE ITEMID = {0}", ID);
            XCTNonQuery(query);
        }
        public bool IsReserved(string PlaatsNR)
        {
            string query = String.Format("SELECT * FROM Reservation r,GuestReservation gr WHERE r.ReservationID = gr.ReservationID AND LocationID = '{0}'", PlaatsNR);
            result = XCTReader(query);
            return result == null ? true : false;
        }
        public void SetItemRental(List<string> irental)
        {
            string query = "SELECT MAX(ITEMRENTALID) FROM ITEMRENTAL";
            result = XCTReader(query);
            int ID = Convert.ToInt32(result) + 1;
            query = String.Format("INSERT INTO CATEGORY VALUES({0}{1}{2})"
                , ID, irental[1], irental[2]);
            XCTNonQuery(query);
        }
    }
}
