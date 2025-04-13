using Angular_and_Core_API.Server.DTO;
using Angular_and_Core_API.Server.Models;

namespace Angular_and_Core_API.Server.IDataService
{
    public interface IDataService
    {

        public List<Category> GetAllCategory();
        public Category GetCategoryFirst();
        public Category GetCategoryByID(int id);
        public Category GetCategoryByName(string Name);
        public bool DeleteCategoryByID(int id);
        public List<Product> GetAllProduct();
        public bool DeleteProductByID(int id);
        public Product GetProductByID(int id);

        public bool Add_Category(CreateCategoryDTO AddCat);
        public bool Update_Category(int id, CreateCategoryDTO NewCategory);

    }
}
