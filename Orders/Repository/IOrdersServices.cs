
using Category.Models;
using System.Collections.Generic;

namespace Login.Repository
{
    public interface IOrdersServices
    {
        public EcomOrders addOrders(int prodid, int custid, int qty, decimal price, string add);
        public EcomOrders getOrdersbyId(int id);
        public IEnumerable<EcomOrders> getOrders();

    }
}
