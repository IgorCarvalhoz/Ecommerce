
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
    public string GetProducts(){
        return "This gonna return the products list";
    }
    [HttpGet("id")]
    public string GetProductsByID(string id){
        return "This code snippet it will returns the product by id";
    } 
    }
}