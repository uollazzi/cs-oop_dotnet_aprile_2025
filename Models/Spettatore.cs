namespace cs_oop.Models;

public class Spettatore : Persona
{
    public Spettatore(string nome, string cognome, DateTime dataNascita, string numeroPostoASedere)
        : base(nome, cognome, dataNascita)
    {
        NumeroPostoASedere = numeroPostoASedere;

        Console.WriteLine("Septtatore creato: " + base.NomeCompleto);
    }

    public string NumeroPostoASedere { get; set; } = string.Empty;
}