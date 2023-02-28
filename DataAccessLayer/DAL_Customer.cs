using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BussinesEntity;

namespace DataAccessLayer
{
    public class DAL_Customer
    {
        AccountingAndSales_DBEntities db = new AccountingAndSales_DBEntities();

        public bool Exist(Table_Customers customer)
        {
            var Query = db.Table_Customers.Any(i => i.Customer_FullName == customer.Customer_FullName && i.Customer_Address == customer.Customer_Address && 
                                                    i.Customer_PhoneNumber ==customer.Customer_PhoneNumber );
            return Query;
        }
        public void register(Table_Customers customer)
        {
            if (!Exist(customer))
            {
                db.Table_Customers.Add(customer);
                db.SaveChanges();
            }
        }
        public List<View_Customer> CustomerReadAll()
        {
            var Query = db.View_Customer.Where(i => i.Customer_Delete == false);
            return Query.ToList();
        }
        public void Update(int id, Table_Customers newCustomer)
        {
            var Query = from i in db.Table_Customers where i.Customer_Delete==false && i.Customer_ID == id select i;
            if (Query.Count() == 1 && !Exist(newCustomer))
            {
                Table_Customers table_Customers = new Table_Customers();
                table_Customers = Query.Single();
                table_Customers.Customer_FullName = newCustomer.Customer_FullName;
                table_Customers.Customer_PhoneNumber = newCustomer.Customer_PhoneNumber;
                table_Customers.Customer_Address = newCustomer.Customer_Address;
                db.SaveChanges();
            }
            
        }
        public void DeleteCustomer(int CustomerID)
        {
            var Query = db.Table_Customers.Where(i => i.Customer_Delete == false && i.Customer_ID == CustomerID);
            if (Query.Count() == 1)
            {
                Table_Customers customer = new Table_Customers();
                customer = Query.SingleOrDefault();
                customer.Customer_Delete = true;
                db.SaveChanges();           
            }
        }
    }
}
