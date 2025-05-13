namespace cs_oop.Models;

// OOP incapsulamento: nascondere lo stato interno e le funzionalità di un oggetto
// e consentire l'accesso solo tramite un set pubblic funzioni
public class Persona
{
    // proprietà
    public string? Nome { get; set; }

    // proprietà full (completamente esplicita)
    private string cognome = string.Empty; // ""
    public string Cognome
    {
        get
        {
            return cognome;
        }
        set
        {
            cognome = value;
        }
    }

    public double Peso { get; set; }

    private int altezza;
    public int Altezza
    {
        get { return altezza; }
        set { altezza = value; }
    }

    // scorciatoie
    // proprietà breve con valore di default
    public string Soprannome { get; set; } = string.Empty;

    // read only
    public int Id { get; private set; }

    // validazione
    private DateTime? dataNascita;
    public DateTime DataNascita
    {
        get
        {
            return dataNascita ?? DateTime.Now;
        }
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Non è ancora nato");

            dataNascita = value;
        }
    }

    // proprità calcolate
    public string NomeCompleto
    {
        get => $"{this.Nome} {this.Cognome}";
    }

    public int Anni { get => (int)Math.Floor(DateTime.Now.Subtract(DataNascita).TotalDays / 365); }
}