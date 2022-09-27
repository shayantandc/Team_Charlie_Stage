
using Category.Models;
using System.Collections.Generic;
using System.Linq;

namespace Login.Repository
{
    public class OrdersServices : IOrdersServices
    {
        private readonly EcomContext _data;



        public OrdersServices(EcomContext data)
        {
            _data = data;
        }
        public EcomOrders addOrders(int prodid, int custid, int qty, decimal price, string add)
        {
            var product = _data.EcomProducts.SingleOrDefault(x => x.ProductId == prodid);
            var cust = _data.EcomCustomers.SingleOrDefault(x => x.CustomerId == custid);

            var orderdetails = new EcomOrders()
            {
                ProductId = prodid,
                CustomerId = custid,
                OrderQuantity = qty,
                OrderPrice = price,
                ShipmentAddress = add,
                Customer = cust,
                Product = product
            };
            _data.EcomOrders.Add(orderdetails);
            _data.SaveChanges();
            return orderdetails;
        }

        public EcomOrders getOrdersbyId(int id)
        {
            var usr = _data.EcomOrders.FirstOrDefault(o => o.CustomerId == id);
            return usr;
        }

        public IEnumerable<EcomOrders> getOrders()
        {
            return _data.EcomOrders.ToList();
        }


    }

}
