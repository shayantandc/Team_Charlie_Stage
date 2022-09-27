using Category.Models;
using System.Collections.Generic;

namespace Category.Repository
{
    public interface ICategory
    {
        EcomCategory getCategoryById(int id);
        IEnumerable<EcomCategory> GetAllCategory();

        EcomCategory AddCategory(string catname);



    }
}
