
using Category.Models;
using MediatR;
using System.Collections.Generic;

namespace Login.Queries
{
    public class GetAllOrders : IRequest<IEnumerable<EcomOrders>>
    {

    }
}