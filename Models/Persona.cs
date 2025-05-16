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

    // metodi
    // sono funzioni
    public string Saluta(string tipoSaluto, string punteggiatura)
    {
        return $"{tipoSaluto}, sono {NomeCompleto} e ho {Anni} anni{punteggiatura}";
    }

    // overload
    public string Saluta(string tipoSaluto)
    {
        return Saluta(tipoSaluto, ".");
    }

    // costruttore
    // metodo che viene automaticamente invocato
    // nel momento in cui istanziamo un oggetto
    // utile anche per valorizzare proprietà in fase di creazione
    public Persona()
    {
        Init();
    }

    public Persona(string nome, string cognome)
    {
        this.Nome = nome;
        this.Cognome = cognome;
        Init();
    }

    private void Init()
    {
        Console.WriteLine("Oggetto istanziato");

    }

    // membri (metodi + proprietà) statici
    // membri che possono essere chiamati dalla classe
    // senza che venga istamziato un oggetto
    // di conseguenza: NON cambiano (dipendono) in base all'istanza
    public static string Specie { get; } = "Mammifero";

    public static string CosaSono()
    {
        return "Sono una persona.";
    }

    public Indirizzo? Indirizzo { get; set; }

    public List<Animale> IMieiAnimali { get; set; } = [];

    public List<string> ColoriPreferiti { get; set; } = [];
}