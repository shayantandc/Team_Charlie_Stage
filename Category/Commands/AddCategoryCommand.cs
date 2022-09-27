using Category.Models;
using MediatR;

namespace Category.Commands
{
    public class AddCategoryCommand:IRequest<EcomCategory>
    {
        public EcomCategory CategoryName{ get; set; }
    }
}
