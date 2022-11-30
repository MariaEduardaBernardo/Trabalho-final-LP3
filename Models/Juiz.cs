namespace Interclasse.Models;
using System.ComponentModel.DataAnnotations;


public class Juiz
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo Esporte")]
    public string? Esporte { get; set; }

    [Required(ErrorMessage = "Preencha o campo Quadra")]
    public int? Quadra { get; set; }

    public Juiz()
    {
    }

    public Juiz(int id, string nome, string esporte, int quadra)
    {
        Id = id;
        Nome = nome;
        Esporte = esporte;
        Quadra = quadra;
    }
}