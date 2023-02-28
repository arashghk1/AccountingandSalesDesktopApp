using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class BLL_UserSystemLog
    {
        DAL_UserSystemLog DAL_systemLog = new DAL_UserSystemLog();

        public void GetSystemInformation(ref string computerName, ref string IPv6, ref string IPv4)
        {
           DAL_systemLog.GetSystemInformation(ref computerName, ref IPv6, ref IPv4);
        }
        public void Register(Table_UserLog userLog)
        {
           DAL_systemLog.Register(userLog);
        }
        public void UpdateExitDate(int UserID, string ExitDate)
        {
           DAL_systemLog.UpdateExitDate(UserID, ExitDate);
        }
        public List<Users_View> GetUserFullNameForComboBox()
        {
            return DAL_systemLog.GetUserFullNameForComboBox();
        }
        public List<View_UserLog> ReadAllUserLog()
        {
            return DAL_systemLog.ReadAllUserLog();
        }
        public List<View_UserLog> ReadUserLogWhitUserIDForComboBox(int User_ID)
        {
            return DAL_systemLog.ReadUserLogWhitUserIDForComboBox(User_ID);
        }
        public List<View_UserLog> ReadUserLogBetweenDate(string dateOne, string dateTwo)
        {
            return DAL_systemLog.ReadUserLogBetweenDate(dateOne, dateTwo);
        }
    }
}
