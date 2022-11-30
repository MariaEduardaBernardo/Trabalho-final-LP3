using Microsoft.AspNetCore.Mvc;
using Interclasse.Models;

namespace Interclasse.Controllers;

public class JuizController : Controller 
{
    private readonly InterclasseContext _context;

    public JuizController(InterclasseContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Juiz);
    }

    public IActionResult Show(int id)
    {
        Juiz juiz = _context.Juiz.Find(id);

        if(juiz == null)
        {
            return NotFound();
        }

        return View(juiz);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Juiz juiz)
    {
        if(!ModelState.IsValid) 
        {
            return View(juiz);
        }

        _context.Juiz.Add(juiz);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Juiz juiz = _context.Juiz.Find(id);

        if(juiz == null)
        {
            return NotFound();
        }

        return View(juiz);
    }

    [HttpPost]
    public IActionResult Update(Juiz juiz, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(juiz);
        }

        Juiz updateJuiz = _context.juiz.Find(juiz.Id);
    
        updateJuiz.Nome = juiz.Nome;
        updateJuiz.Esporte = juiz.esporte;
        updateJuiz.Quadra = juiz.Quadra;
        
        _context.Juiz.Update(updateJuiz);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Juiz juiz = _context.Juiz.Find(id);

        if(juiz == null)
        {
            return NotFound();
        }
        
        _context.Juiz.Remove(_context.Juiz.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}