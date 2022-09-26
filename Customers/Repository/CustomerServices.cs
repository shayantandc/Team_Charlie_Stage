using Login.Models;
using System.Collections.Generic;
using System.Linq;

namespace Login.Repository
{
    public class CustomerServices : ICustomerServices
    {
        private readonly EcomContext _data;



        public CustomerServices(EcomContext data)
        {
            _data = data;
        }
        public EcomCustomers addCustomers(string name, string add, string phone, string email, int loginid)
        {
            //int logid = loginid;
            string Name = name;
            //var cust = _data.EcomCustomers.SingleOrDefault(x => x.LoginId == loginid);
            string Add = add;
            string Phone = phone;
            string Email = email;
            int Loginid = loginid;

            var custdetails = new EcomCustomers()
            {
                CustomerName = Name,
                CustomerAddress = Add,
                CustomerPhoneNumber = Phone,
                CustomerEmailId =  Email,
                LoginId = Loginid,
            };
            _data.EcomCustomers.Add(custdetails);
            _data.SaveChanges();
            return custdetails;
        }

        public EcomCustomers getCustomersbyId(int id)
        {
            var usr = _data.EcomCustomers.FirstOrDefault(o => o.CustomerId == id);
            return usr;
        }

        public IEnumerable<EcomCustomers> getCustomers()
        {
            return _data.EcomCustomers.ToList();
        }

        
    }

}
