namespace Interclasse.Models;
using System.ComponentModel.DataAnnotations;


public class Partida
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Instituição onde ocorrera o jogo")]
    public string? Local { get; set; }

    [Required(ErrorMessage = "Preencha o campo Hora")]
    public int? Hora { get; set; }

    [Required(ErrorMessage = "Preencha o campo Esporte")]
    public string? Esporte { get; set; }

    public Partida()
    {
    }

    public Partida(int id, string local, int hora, string esporte)
    {
        Id = id;
        Local = local;
        Hora = hora;
        Esporte = esporte;
    }
}