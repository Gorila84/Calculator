using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        void DeleteCategory(int categoryId);
        int AddCategory(Category category);
        int UpdateCategory(Category category);
        Category GetCategory(int categoryId);
        IQueryable<Category> GetAllCategorys();
    }
}
