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



    }
}
