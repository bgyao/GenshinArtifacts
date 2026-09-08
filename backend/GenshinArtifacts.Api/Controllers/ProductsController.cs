using Microsoft.AspNetCore.Mvc;
using GenshinArtifacts.Api.Models;

namespace GenshinArtifacts.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> _products = new();
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        return _products;
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        return product;
    }

    [HttpPost]
    public ActionResult<Product> CreateProduct(Product product)
    {
        product.Id = _nextId++;

        _products.Add(product);

        // This will return a 201 Created response with the location of the newly created product.
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }
}