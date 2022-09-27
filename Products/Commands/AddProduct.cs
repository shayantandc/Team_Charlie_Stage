
using Category.Models;
using MediatR;

namespace Products.Commands
{
    public class AddProduct : IRequest<EcomProducts>
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }

    }
}
