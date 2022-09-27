using Category.Commands;
using Category.Models;
using Category.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Category.Handlers
{
    public class AddCategoryHandler : IRequestHandler<AddCategoryCommand, EcomCategory>
    {
        private readonly ICategory _data;
        public AddCategoryHandler(ICategory data)
        {
            _data = data;
        }

        public async Task<EcomCategory> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_data.AddCategory(request.CategoryName));
        }
    }
}
