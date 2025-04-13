using Angular_and_Core_API.Server.DTO;
using Angular_and_Core_API.Server.IDataService;
using Angular_and_Core_API.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Angular_and_Core_API.Server.DataService
{
    public class DataService : Angular_and_Core_API.Server.IDataService.IDataService
    {
        private readonly MyDbContext _dbContext;

        public DataService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetAllCategory()
        {
            var AllData = _dbContext.Categories.ToList();

            return AllData;

        }


        public Category GetCategoryFirst()
        {
            var AllData = _dbContext.Categories.ToList();

            return AllData.First();

        }


        public Category GetCategoryByID(int id)
        {
            var Category_Id = _dbContext.Categories.FirstOrDefault(d => d.CategoryId == id);

            return Category_Id;

        }

        public bool DeleteCategoryByID(int id)
        {
            var Category_Id = _dbContext.Categories.FirstOrDefault(d => d.CategoryId == id);

            if(Category_Id == null)
            {
                return false;
            }

            _dbContext.Categories.Remove(Category_Id);
            _dbContext.SaveChanges();


            return true;
            

        }

        public Category GetCategoryByName(string Name)
        {
            var Category_Name = _dbContext.Categories.FirstOrDefault(d => d.CategoryName == Name);

            return Category_Name;

        }


        public List<Product> GetAllProduct()
        {
            var AllData = _dbContext.Products.ToList();

            return AllData;

        }

        public Product GetProductByID(int id)
        {
            var Product_Id = _dbContext.Products.FirstOrDefault(d => d.Id == id);

            return Product_Id;

        }


        public bool Add_Category(CreateCategoryDTO AddCat)
        {
            var Categor = new Category
            {
                CategoryName = AddCat.CategoryName,
                CategoryDesc = AddCat.CategoryDesc,
            };

            _dbContext.Add(Categor);
            _dbContext.SaveChanges();

            return true;

        }


        public bool Update_Category(int id, CreateCategoryDTO NewCategory)
        {

            var Cat = _dbContext.Categories.Find(id);

            if (Cat == null)
            {
                return false;
            }


            Cat.CategoryName = NewCategory.CategoryName;
            Cat.CategoryDesc = NewCategory.CategoryDesc;

            _dbContext.SaveChanges();

            return true;


        }

        public bool DeleteProductByID(int id)
        {
            var Product_Id = _dbContext.Products.FirstOrDefault(d => d.Id == id);

            if (Product_Id == null)
            {
                return false;
            }

            _dbContext.Products.Remove(Product_Id);
            _dbContext.SaveChanges();


            return true;


        }

    }
}
