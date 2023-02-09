using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    [HttpGet]
    public DateTime InformarHorario()
    {
        return DateTime.Now;
    }
}
