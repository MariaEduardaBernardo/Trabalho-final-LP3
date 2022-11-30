namespace Interclasse.Models;
using System.ComponentModel.DataAnnotations;


public class Quadra
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Numero da quadra")]
    public int? Numero { get; set; }

    [Required(ErrorMessage = "Preencha o campo Esporte")]
    public string? Esporte { get; set; }

    public Quadra() { }

    public Quadra (int id, int numero, string esporte)
    {
        Id = id;
        Numero = numero;
        Esporte = esporte;
    }
}
