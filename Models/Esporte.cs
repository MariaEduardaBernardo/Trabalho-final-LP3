namespace Interclasse.Models;
using System.ComponentModel.DataAnnotations;

public class Esporte{

    public int Id { get; set; }

    [Required(ErrorMessage = "Nome do esporte")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Quantidade de participantes para a modalidade")]
    public int Participantes { get; set; }

    public Esporte()
    {

    }

    public Esporte(int id, string nome, int participantes)
    {
        Id = id;
        Nome = nome;
        Participantes = participantes;
    }
}
