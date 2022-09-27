using Category.Models;
using MediatR;

namespace Category.Commands
{
    public class AddCategoryCommand:IRequest<EcomCategory>
    {
        public string CategoryName{ get; set; }
    }
}
