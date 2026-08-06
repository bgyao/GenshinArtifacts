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
}