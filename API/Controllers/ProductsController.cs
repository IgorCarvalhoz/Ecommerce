
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.VisualBasic;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
    [HttpGet("List")]
    public string IActionResult(){
        return "This gonna return the products list";
    }
    [HttpGet("Id")]
    public string IActionResult(string id){
        return "This code snippet it will return the product by id";
    } 
    }
}