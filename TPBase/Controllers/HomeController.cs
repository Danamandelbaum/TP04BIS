using Microsoft.AspNetCore.Mvc;

namespace TP4BISMANDELBAUM.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.listaPaises = Info.listarPaises();
        return View("Index");
    }

    public IActionResult detallePais(string pais)
    {
        ViewBag.paisBuscado = Info.DetallePais(pais);
        return View("detallePais");
    }
}
