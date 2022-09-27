
using Category.Models;
using System.Collections.Generic;
using System.Linq;

namespace Products.Repository
{
    public class ProductsServices : IProductServices
    {
        private readonly EcomContext _data;



        public ProductsServices(EcomContext data)
        {
            _data = data;
        }
        public EcomProducts addProducts(int catid, string name, string type, decimal price, string desc)
        {
            //var product = _data.EcomProducts.SingleOrDefault(x => x.ProductId == prodid);
            var cust = _data.EcomCategory.SingleOrDefault(x => x.CategoryId == catid);

            var prodetails = new EcomProducts()
            {
                //ProductId = prodid,
                CategoryId = catid,
                ProductName = name,
                ProductType = type,
                ProductPrice = price,
                ProductDescription = desc,
                Category = cust
            };
            _data.EcomProducts.Add(prodetails);
            _data.SaveChanges();
            return prodetails;
        }

        public EcomProducts getProductsbyId(int id)
        {
            var usr = _data.EcomProducts.FirstOrDefault(o => o.CategoryId == id);
            return usr;
        }

        public IEnumerable<EcomProducts> getProducts()
        {
            return _data.EcomProducts.ToList();
        }


    }

}
