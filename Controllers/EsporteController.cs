using Microsoft.AspNetCore.Mvc;
using Interclasse.Models;

namespace Interclasse.Controllers;

public class EsporteController : Controller 
{
    private readonly InterclasseContext _context;

    public EsporteController(InterclasseContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Esporte);
    }

    public IActionResult Show(int id)
    {
        Esporte esporte = _context.Esporte.Find(id);

        if(esporte == null)
        {
            return NotFound();
        }

        return View(esporte);
    }
}