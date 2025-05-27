using CsvHelper.Configuration.Attributes;

namespace cs_oop.Models;

public class Persona
{
    [Name("id")] // attributo / decoratore
    public int Id { get; set; }

    [Name("nome")]
    public string Nome { get; set; } = string.Empty;

    [Name("cognome")]
    public string Cognome { get; set; } = string.Empty;

    [Name("dataNascita")]
    public int DataNascitaEpoch { get; set; }

    public DateTimeOffset DataNascita { get => DateTimeOffset.FromUnixTimeSeconds(DataNascitaEpoch); }

    // sovrascrive la rappresentazione in stringa dell'oggetto Persona
    public override string ToString()
    {
        return $"{Id} - {Nome} {Cognome} nato il {DataNascita.LocalDateTime.ToString(@"dd MMMM \del yyyy")}";
    }
}