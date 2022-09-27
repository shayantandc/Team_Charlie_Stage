using Category.Models;
using MediatR;

namespace Login.Commands
{
    public class AddOrder : IRequest<EcomOrders>
    {
        public int Productid { get; set; }
        public int Custid { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Add { get; set; }
    }
}
