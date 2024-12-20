using Microsoft.AspNetCore.Mvc;
class ProductController : Controller
{
    private readonly List<Product> products = new List<Product>();

    public IActionResult CreateProject()
    {
        products.Add(new Product { Id = 1, Name = "Product 1", Price = 10 });
        return Ok(products);
    }

    public IActionResult GetProductById(int id){
        var product = products.FirstOrDefault(p => p.Id == id);
        if(product == null){
            return NotFound();
        }
        return Ok(product);
    }
}