using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class BLL_Customer
    {
        DAL_Customer DAL_customer = new DAL_Customer(); 

        public void register(Table_Customers customer)
        {
           DAL_customer.register(customer);
        }
        public List<View_Customer> CustomerReadAll()
        {
            return DAL_customer.CustomerReadAll();
        }
        public void Update(int id, Table_Customers newCustomer)
        {
            DAL_customer.Update(id, newCustomer);
        }
        public void DeleteCustomer(int CustomerID)
        {
            DAL_customer.DeleteCustomer(CustomerID);
        }
    }
}
