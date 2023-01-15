using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
namespace ProductController;
using PMSWebApi.Model;
using PMSWebApi.DAL;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<Product> GetAllProduct()
    {
        List<Product> product=ProductAccess.GetAllProduct();
        return product;
    }

    [HttpPost]
    [EnableCors()]
    public IActionResult InserProduct(Product product){
        ProductAccess.SaveProduct(product);
        return Ok(new {message ="Product created"});
    }

    [Route("{id}")]
    [HttpDelete]
    [EnableCors()]
      public ActionResult<Product> DeleteProduct(int id){
        ProductAccess.DeleteProductById(id);
        return Ok(new {message ="Product deleted"});
    }

    
    [Route("{id}")]
    [HttpPut]
    [EnableCors()]
      public ActionResult<Product> UpdateProduct(Product product){
        ProductAccess.UpdateProductById(product);
        return Ok(new {message ="Product upated"});
    }

}