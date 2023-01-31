using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers;

[Controller]
[Route("[controller]")]
public class ProdutoController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
