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
}