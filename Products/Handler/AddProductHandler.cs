using Products.Commands;
using Products.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Category.Models;

namespace Products.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProduct, EcomProducts>
    {
        private readonly IProductServices _data;
        public AddProductHandler(IProductServices data)
        {
            _data = data;
        }

        public Task<EcomProducts> Handle(AddProduct request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.addProducts(request.CatId, request.Name, request.Type, request.Price, request.Desc));
        }
    }
}

