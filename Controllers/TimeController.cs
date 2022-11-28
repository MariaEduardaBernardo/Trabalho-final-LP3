using Microsoft.AspNetCore.Mvc;
using Interclasse.Models;

namespace Interclasse.Controllers;

public class TimeController : Controller 
{
    private readonly InterclasseContext _context;

    public TimeController(InterclasseContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Time);
    }

    public IActionResult Show(int id)
    {
        Time time = _context.Time.Find(id);

        if(time == null)
        {
            return NotFound();
        }

        return View(time);
    }
}