// deve eriditare da persona
// prop string Squadra
// fate il costruttore per passare nome, cognome e dataNascita, squadra
using cs_oop.Interfaces;

namespace cs_oop.Models;

public class Allenatore : Persona, ITrasferibile, IEsonerabile
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

    public override string Saluta(string TipoSaluto, string punteggiatura)
    {
        return $"{base.Saluta(TipoSaluto, punteggiatura)}\nAlleno i {Squadra}";
    }

    public void TrasferiscimiA(string nuovaSquadra)
    {
        Squadra = nuovaSquadra;
    }

    private DateTime? dataUltimoEsonero;
    public DateTime? DataUltimoEsonero
    {
        get
        {
            return dataUltimoEsonero;
        }
    }

    public void Esonerami(DateTime dataEsonero)
    {
        Squadra = "NESSUNA";
        dataUltimoEsonero = dataEsonero;
    }
}