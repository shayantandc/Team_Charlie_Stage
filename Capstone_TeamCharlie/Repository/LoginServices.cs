using Login.Models;
using System.Collections.Generic;
using System.Linq;

namespace Login.Repository
{
    public class LoginServices : ILogin
    {
        private readonly EcomContext _data;



        public LoginServices(EcomContext data)
        {
            _data = data;
        }
        public EcomLogin register(string pass,string email)
        {
            //int logid = loginid;
            string pas = pass;
            //var cust = _data.EcomCustomers.SingleOrDefault(x => x.LoginId == loginid);
            string role = "User";
            string Em = email;

            var logindetails = new EcomLogin()
            {
                //LoginId = logid,
                Password = pas,
                LoginRole = role,
                DateTimeStamp = System.DateTime.Now,
                Token = "eiueujdjjdjddjjjdj",
                UserEmail = Em
                //Cust = cust
            };
            _data.EcomLogin.Add(logindetails);
            _data.SaveChanges();
            return logindetails;
        }

        public EcomLogin getUsersbyId(int id)
        {
            var usr = _data.EcomLogin.FirstOrDefault(o => o.LoginId == id);
            return usr;
        }

        public IEnumerable<EcomLogin> getUsers()
        {
            return _data.EcomLogin.ToList();
        }

        
    }

}
