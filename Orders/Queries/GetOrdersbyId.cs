
using Category.Models;
using MediatR;

namespace Login.Queries
{
    public class GetOrdersbyId : IRequest<EcomOrders>
    {
        public int Id { get; set; }
    }
}
