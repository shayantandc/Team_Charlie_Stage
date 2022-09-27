using Category.Models;
using Login.Commands;

using Login.Queries;
using Login.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class GetOrdersbyIdHandler : IRequestHandler<GetOrdersbyId, EcomOrders>
    {
        private readonly IOrdersServices _data;
        public GetOrdersbyIdHandler(IOrdersServices data)
        {
            _data = data;
        }

        public Task<EcomOrders> Handle(GetOrdersbyId request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getOrdersbyId(request.Id));
        }
    }
}