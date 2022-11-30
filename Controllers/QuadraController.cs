using Microsoft.AspNetCore.Mvc;
using Interclasse.Models;

namespace Interclasse.Controllers;

public class QuadraController : Controller 
{
    private readonly InterclasseContext _context;

    public QuadraController(InterclasseContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Quadra);
    }

    public IActionResult Show(int id)
    {
        Quadra quadra = _context.Quadra.Find(id);

        if(quadra == null)
        {
            return NotFound();
        }

        return View(quadra);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Quadra quadra)
    {
        if(!ModelState.IsValid) 
        {
            return View(quadra);
        }

        _context.Quadra.Add(quadra);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Quadra quadra = _context.Quadra.Find(id);

        if(quadra == null)
        {
            return NotFound();
        }

        return View(quadra);
    }

    [HttpPost]
    public IActionResult Update(Quadra quadra, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(quadra);
        }

        Quadra updateQuadra = _context.quadra.Find(quadra.Id);
    
        updateQuadra.Numero = quadra.Numero;
        updateQuadra.Esporte = quadra.esporte;
        

        _context.Quadra.Update(updateQuadra);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Quadra quadra = _context.Quadra.Find(id);

        if(quadra == null)
        {
            return NotFound();
        }
        
        _context.Quadra.Remove(_context.Quadra.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}