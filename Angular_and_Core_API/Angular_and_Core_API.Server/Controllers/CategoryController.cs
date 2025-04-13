using Angular_and_Core_API.Server.DTO;
using Angular_and_Core_API.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_and_Core_API.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

         private readonly Angular_and_Core_API.Server.IDataService.IDataService _dataService;



        public CategoryController(Angular_and_Core_API.Server.IDataService.IDataService dataService)
        {
           
            _dataService = dataService;
            
        }


        [HttpGet ("Category")]
        public IActionResult GetAllCategory()
        {
            var AllData = _dataService.GetAllCategory();

            return Ok(AllData);

        }

        [HttpPost("AddCategory")]
        public IActionResult AddNewCategory([FromForm]CreateCategoryDTO NewCategory)
        {
            if(NewCategory == null)
            {
                return BadRequest();
            }

            _dataService.Add_Category(NewCategory);
            return Ok("Add data is successfully");

        }


        [HttpPut("Update/{id}")]
        public IActionResult Update(int id,[FromForm] CreateCategoryDTO NewCategory)
        {
            if (NewCategory == null)
            {
                return BadRequest();
            }

            if(_dataService.Update_Category(id, NewCategory))
            {
                return Ok("Update Data is Successfully");
            }
           
            return BadRequest();

        }


        [HttpGet("GetCategoryFirst")]
       
        public IActionResult GetCategoryFirst()
        {
            var AllData = _dataService.GetCategoryFirst();
            
            return Ok(AllData);

        }

        [HttpGet("GetCategoryByID")]
        public IActionResult GetCategoryByID(int id)
        {
            var Category_Id = _dataService.GetCategoryByID(id);

            return Ok(Category_Id);

        }

        [HttpGet("GetCategoryByName")]
        public IActionResult GetCategoryByName(string Name)
        {
            var Category_Name = _dataService.GetCategoryByName(Name);

            if(Category_Name == null)
            {
                return NotFound();
            }

            return Ok(Category_Name);

        }


        [HttpDelete("DeleteCategoryByID")]
        public IActionResult DeleteCategoryByID(int Id)
        {
            var Category = _dataService.DeleteCategoryByID(Id);

            if (Category == null)
            {
                return NotFound();
            }

            return Ok();

        }

    }
}
