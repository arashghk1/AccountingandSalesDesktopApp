using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using BussinesEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class DAL_UserSystemLog
    {
        AccountingAndSales_DBEntities db = new AccountingAndSales_DBEntities();

        public void GetSystemInformation(ref string computerName , ref string IPv6 , ref string IPv4)
        {
            // Get Computer Name:
            computerName = System.Environment.MachineName;


            // Get IP V4:
            //IPHostEntry iPHostEntry = Dns.GetHostByName(computerName); // Just IP Version 4
            IPHostEntry iPHostEntry = Dns.GetHostEntry(computerName);
            IPAddress[] iPAddresses = iPHostEntry.AddressList;
            IPv6 = iPAddresses[0].ToString();
            IPv4 = iPAddresses[2].ToString();
        }
        public void Register(Table_UserLog userLog)
        {
            db.Table_UserLog.Add(userLog);
            db.SaveChanges();
        }
        public void UpdateExitDate(int UserID , string ExitDate)
        {
            db.sp_Update_ExitDateInUserLogTable(UserID, ExitDate);
            db.SaveChanges();
        }
        public List<Users_View> GetUserFullNameForComboBox()
        {
            return db.Users_View.ToList();

        }
        public List<View_UserLog> ReadAllUserLog()
        {
            return db.View_UserLog.ToList();
        }

        public List<View_UserLog> ReadUserLogWhitUserIDForComboBox(int user_ID)
        {
            var Query = from i in db.View_UserLog.Where(i => i.User_ID == user_ID ) select i;
            return Query.ToList();
        }


        public List<View_UserLog> ReadUserLogBetweenDate(string dateOne , string dateTwo)
        {
            var Query = from i in db.View_UserLog where 
                        i.UserLog_EnterDate.CompareTo(dateOne) >= 0 &&
                        i.UserLog_EnterDate.CompareTo(dateTwo) <= 0 select i;
            return Query.ToList();
        }


    }
}
