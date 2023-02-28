using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BussinesEntity;

namespace BussinesLogicLayer
{
    public class BLL_User
    {
        DAL_User DAL_user = new DAL_User();

        public byte Login(string userName, string Password)
        {
            return DAL_user.Login(userName, Password);
        }
        public void Register(Table_Users user)
        {
            DAL_user.register(user);
        }
        public List<Users_View> UserReadAll()
        {
            return DAL_user.UsersReadAll();
        }
        public string PasswordHashing(string InputValue)
        {
           return DAL_user.PasswordHashing(InputValue);
        }
        public Table_Users GetUserInformation(string username, string password)
        {
            return DAL_user.GetUserInformation(username, password);
        }
        public List<Users_View> ReadUserByString(string InputValue)
        {
           return DAL_user.ReadUserByString(InputValue);
        }
        public List<Users_View> ReadUserLogBetweenDate(string dateOne, string dateTwo)
        {
           return DAL_user.ReadUserLogBetweenDate(dateOne, dateTwo);
        }
        public void Update(int UserID, Table_Users newUser)
        {
            DAL_user.Update(UserID, newUser);
        }
        public List<Users_View> ActiveUserRead()
        {
            return DAL_user.ActiveUserRead();
        }
        public List<Users_View> DeActiveUserRead()
        {
            return DAL_user.DeActiveUserRead();
        }
        public bool CheckExistPass(int userID,string pass)
        {
            return DAL_user.CheckExistPass(userID ,pass);
        }
        public void UpdatePassword(int userID, string UserNewPass)
        {
            DAL_user.UpdatePassword(userID, UserNewPass);
        }
        public void DeleteUser(int UserID)
        {
            DAL_user.DeleteUser(UserID);
        }

        public bool checkUserExist()
        {
           return DAL_user.checkUserExist();
        }

    }
}
