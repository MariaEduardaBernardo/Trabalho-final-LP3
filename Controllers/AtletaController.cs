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

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Atleta atleta)
    {
        if(!ModelState.IsValid) 
        {
            return View(atleta);
        }

        _context.Atleta.Add(atleta);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Atleta atleta = _context.Atleta.Find(id);

        if(atleta == null)
        {
            return NotFound();
        }

        return View(atleta);
    }

    [HttpPost]
    public IActionResult Update(Atleta atleta, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(atleta);
        }

        Atleta updateAtleta = _context.Atleta.Find(atleta.Id);
        
        updateAtleta.Nome = atleta.Nome;
        updateAtleta.Esporte = atleta.Esporte;
        updateAtleta.Numero = atleta.Numero;

        _context.Atleta.Update(updateAtleta);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Atleta atleta = _context.Atleta.Find(id);

        if(atleta == null)
        {
            return NotFound();
        }
        
        _context.Atleta.Remove(_context.Atleta.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}