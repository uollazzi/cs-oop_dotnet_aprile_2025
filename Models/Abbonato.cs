namespace cs_oop.Models;

public class Abbonato : Spettatore
{
    public Abbonato(string nome, string cognome, DateTime dataNascita, string numeroPostoASedere, string codiceAbbonamento)
            : base(nome, cognome, dataNascita, numeroPostoASedere)
    {
        CodiceAbbonamento = codiceAbbonamento;
    }

    public string CodiceAbbonamento { get; set; } = string.Empty;
}