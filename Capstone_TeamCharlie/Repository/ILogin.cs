using Login.Models;
using System.Collections.Generic;

namespace Login.Repository
{
    public interface ILogin
    {
        public EcomLogin register(string pass,string email);
        public EcomLogin getUsersbyId(int id);
        public IEnumerable<EcomLogin> getUsers();
        
    }
}
