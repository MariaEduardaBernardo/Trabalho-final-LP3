using Microsoft.AspNetCore.Mvc;
using Interclasse.Models;

namespace Interclasse.Controllers;

public class AtletaController : Controller 
{
    private readonly InterclasseContext _context;

    public AtletaController(InterclasseContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Atleta);
    }

    public IActionResult Show(int id)
    {
        Atleta atleta = _context.Atleta.Find(id);

        if(atleta == null)
        {
            return NotFound();
        }

        return View(atleta);
    }
}