using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BussinesEntity;
using System.Security.Cryptography;
namespace DataAccessLayer
{
    public class DAL_User
    {
        AccountingAndSales_DBEntities db=new AccountingAndSales_DBEntities();
        public bool Exist(Table_Users user)
        {
            var Query = db.Table_Users.Any(i => i.User_Username == user.User_Username && i.User_Paasword == user.User_Paasword);
            return Query;
        }

        public bool checkUserExist()
        {
            var query = db.Table_Users.ToList();
            if (query.Count() == 1)
            {
                return true;
            }
            return false;
        }


        public byte Login(string userName , string Password)
        {
            var Query = db.Table_Users.Any(i =>i.User_Active == true && i.User_Delete==false && i.User_Username == userName && i.User_Paasword == Password);
            if (!Query)
            {
                return 0;
            }
            else if (Query)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public String register(Table_Users users)
        {
            if (!Exist(users))
            {
                db.Table_Users.Add(users);
                db.SaveChanges();
            }
            return "UserName Is Exist In System Please Check Another One.";
                    
        }
        public List<Users_View> UsersReadAll()
        {
            var Query = db.Users_View.Where(i => i.User_Delete == false);
            return Query.ToList();
        }
        public string PasswordHashing(string InputValue)
        {

            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            Byte[] B1;
            Byte[] B2;
            B1 = UTF32Encoding.UTF8.GetBytes(InputValue);
            B2 = sha256.ComputeHash(B1);
            string UserPasswordHashed = BitConverter.ToString(B2);
            return UserPasswordHashed;

        }
        public Table_Users GetUserInformation(string username , string password)
        {
            var Query =from i in db.Table_Users where i.User_Delete==false && i.User_Username == username && i.User_Paasword == password select i;
            return Query.Single();
        }
        public List<Users_View> ReadUserByString(string InputValue)
        {
            var Query = db.Users_View.Where(i =>i.User_Delete==false && (i.User_FirstName.Contains(InputValue) || i.User_LastName.Contains(InputValue) ||
                                                i.User_Tel.Equals(InputValue)));
            return Query.ToList();
        }
        public List<Users_View> ReadUserLogBetweenDate(string dateOne, string dateTwo)
        {
            var Query = from i in db.Users_View
                        where
                        i.User_Delete == false &&
                        i.User_StartDate.CompareTo(dateOne) >= 0 &&
                        i.User_StartDate.CompareTo(dateTwo) <= 0
                        select i;
            return Query.ToList();
        }
        public void Update(int UserID , Table_Users newUser)
        {
            var Query = from i in db.Table_Users where i.User_ID == UserID select i;
            if (Query.Count() == 1 )
            {
                Table_Users user = new Table_Users();
                user = Query.Single();
                user.User_FirstName = newUser.User_FirstName;
                user.User_LastName = newUser.User_LastName;
                user.User_Tel = newUser.User_Tel;
                user.User_Age = newUser.User_Age;
                user.User_Gender = newUser.User_Gender;
                user.User_Delete = false;
                db.SaveChanges();
            }
        }
        public List<Users_View> ActiveUserRead()
        {
            var Query = db.Users_View.Where(i => i.User_Delete==false && i.User_Active == "Active");
            return Query.ToList();
        }
        public List<Users_View> DeActiveUserRead()
        {
            var Query = db.Users_View.Where(i => i.User_Delete==false && i.User_Active == "DeActive");
            return Query.ToList();
        }
        public bool CheckExistPass(int userID,string pass)
        {
            var Query =db.Table_Users.Any(i =>i.User_Delete == false && i.User_Active == true && i.User_ID == userID && i.User_Paasword == pass);
            return Query;
        }
        public void UpdatePassword(int userID , string UserNewPass)
        {
            var Query = db.Table_Users.Where(i => i.User_Delete == false && i.User_Active== true && i.User_ID == userID).SingleOrDefault();
            Query.User_Paasword = UserNewPass;
            db.SaveChanges();


        }
        public void DeleteUser(int UserID)
        {
            var Query = db.Table_Users.Where(i => i.User_Delete == false && i.User_ID == UserID);
            if (Query.Count() == 1)
            {
                Table_Users user = new Table_Users();
                user = Query.Single();
                user.User_Delete = true;
                db.SaveChanges();
            }
        }



    }
}
