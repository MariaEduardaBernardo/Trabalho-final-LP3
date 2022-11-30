using Microsoft.AspNetCore.Mvc;
using Interclasse.Models;

namespace Interclasse.Controllers;

public class PartidaController : Controller 
{
    private readonly InterclasseContext _context;

    public PartidaController(InterclasseContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Partida);
    }

    public IActionResult Show(int id)
    {
        Partida partida = _context.Partida.Find(id);

        if(partida == null)
        {
            return NotFound();
        }

        return View(partida);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Partida partida)
    {
        if(!ModelState.IsValid) 
        {
            return View(partida);
        }

        _context.Partida.Add(partida);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Partida partida = _context.Partida.Find(id);

        if(partida == null)
        {
            return NotFound();
        }

        return View(partida);
    }

    [HttpPost]
    public IActionResult Update(Partida partida, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(partida);
        }

        Partida updatePartida = _context.partida.Find(partida.Id);
    
        updatePartida.Local = partida.Local;
        updatePartida.Hora = partida.Hora;
        updatePartida.Esporte = partida.esporte;
        

        _context.Partida.Update(updatePartida);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Partida partida = _context.Partida.Find(id);

        if(partida == null)
        {
            return NotFound();
        }
        
        _context.Partida.Remove(_context.Partida.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}