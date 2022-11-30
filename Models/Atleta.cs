namespace Interclasse.Models;
using System.ComponentModel.DataAnnotations;

public class Atleta{

    public int Id { get; set; }

    [Required(ErrorMessage = "Nome obrigatorio")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Esporte obrigatorio")]
    public string Esporte { get; set; }

    [Required(ErrorMessage = "Numero do atleta obrigatorio")]
    public int Numero { get; set; }

    public Atleta()
    {
    }

    public Atleta(int id, string nome, string esporte, int numero)
    {
        Id = id;
        Nome = nome;
        Esporte = esporte;
        Numero = numero; 
    }
}