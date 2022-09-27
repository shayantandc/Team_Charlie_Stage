
using Category.Models;
using System.Collections.Generic;

namespace Products.Repository
{
    public interface IProductServices
    {
        public EcomProducts addProducts(int custid, string name, string type, decimal price, string desc);
        public EcomProducts getProductsbyId(int id);
        public IEnumerable<EcomProducts> getProducts();

    }
}

