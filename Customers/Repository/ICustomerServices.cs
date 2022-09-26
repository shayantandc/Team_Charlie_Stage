using Login.Models;
using System.Collections.Generic;

namespace Login.Repository
{
    public interface ICustomerServices
    {
        public EcomCustomers addCustomers(string name,string add, string phone, string email, int loginid);
        public EcomCustomers getCustomersbyId(int id);
        public IEnumerable<EcomCustomers> getCustomers();
        
    }
}
