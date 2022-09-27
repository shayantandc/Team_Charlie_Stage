using Category.Models;
using Login.Commands;
using Login.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class AddOrderHandler : IRequestHandler<AddOrder, EcomOrders>
    {
        private readonly IOrdersServices _data;
        public AddOrderHandler(IOrdersServices data)
        {
            _data = data;
        }

        public Task<EcomOrders> Handle(AddOrder request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.addOrders(request.Productid, request.Custid, request.Qty, request.Price, request.Add));
        }
    }
}