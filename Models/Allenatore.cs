// deve eriditare da persona
// prop string Squadra
// fate il costruttore per passare nome, cognome e dataNascita, squadra
namespace cs_oop.Models;

public class Allenatore : Persona
{
    public string Squadra { get; set; } = string.Empty;

    public Allenatore(string nome, string cognome, DateTime dataNascita, string squadra)
        : base(nome, cognome, dataNascita)
    {
        Squadra = squadra;

    }

    public string Rimprovera(Persona persona)
    {
        if (persona.GetType() == typeof(Cestista))
        {
            return $"{persona.NomeCompleto}, passa la palla!";
        }

        return $"{persona.NomeCompleto}, fai pù attenzione!";
    }
}