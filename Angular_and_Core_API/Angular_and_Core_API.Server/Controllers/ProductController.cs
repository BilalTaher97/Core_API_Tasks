using Angular_and_Core_API.Server.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Angular_and_Core_API.Server.Controllers
{
    public class ProductController : Controller
    {
        private readonly Angular_and_Core_API.Server.IDataService.IDataService _dataService;

        public ProductController(Angular_and_Core_API.Server.IDataService.IDataService dataService)
        {

            _dataService = dataService;

        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("Product")]
        public IActionResult GetAllProduct()
        {
            var AllData = _dataService.GetAllProduct();

            return Ok(AllData);

        }

        [HttpGet("GetProductByID")]
        public IActionResult GetProductByID(int id)
        {
            var AllData = _dataService.GetProductByID(id);

            if (AllData == null)
            {
                return NotFound();
            }

            return Ok(AllData);

        }

        [HttpDelete("DeleteProductByID")]
        public IActionResult DeleteProductByID(int id)
        {
            if(_dataService.DeleteProductByID(id))
            {
                return Ok();
            }

           return NotFound();

        }

        [HttpPost("AddProduct")]
        public IActionResult AddNewProduct([FromBody] CreateProductDTO NewProduct)
        {
            if (NewProduct == null)
            {
                return BadRequest();
            }

            _dataService.Add_Product(NewProduct);
            return Ok();

        }


        [HttpPut("EditProduct/{id}")]
        public IActionResult EditProduct([FromBody] CreateProductDTO NewProduct,int id)
        {
            if (NewProduct == null)
            {
                return BadRequest();
            }

            _dataService.Edit_Product(NewProduct,id);
            return Ok();

        }

        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {

            if(_dataService.Delete_Product(id))
            {
                return Ok();
            }

            return BadRequest();


        }
    }
}
