
using Category.Models;
using Login.Queries;
using Login.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class GetOrdersHandler : IRequestHandler<GetAllOrders, IEnumerable<EcomOrders>>
    {
        private readonly IOrdersServices _data;
        public GetOrdersHandler(IOrdersServices data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomOrders>> Handle(GetAllOrders request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getOrders());
        }
    }
}