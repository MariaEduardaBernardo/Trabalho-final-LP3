namespace Interclasse.Models;
using System.ComponentModel.DataAnnotations;


public class Time
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Estado")]
    public String? Estado { get; set; }

    [Required(ErrorMessage = "Preencha o campo Tecnico")]
    public String? Tecnico { get; set; }

    public Time()
    {
    }

    public Time(int id, string estado, string tecnico)
    {
        Id = id;
        Estado = estado;
        Tecnico = tecnico;
    }
}