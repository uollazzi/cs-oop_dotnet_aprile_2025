namespace cs_oop.Models;

public partial class Cestista : Persona
{
    public Cestista()
    {
        Console.WriteLine("Cestista creato");
    }

    public string Squadra { get; set; } = string.Empty;

    public int Numero { get; set; }

    public int ValoreSchiacciata { get; set; }

    public bool Schiaccia()
    {
        return new Random().Next(100) <= ValoreSchiacciata;
    }

    public Cestista(string nome, string cognome, DateTime dataNascita, string squadra, int numero)
        : base(nome, cognome, dataNascita)
    {
        Squadra = squadra;
        Numero = numero;
    }

    public override string Saluta(string tipoSaluto, string punteggiatura)
    {
        string saluto = base.Saluta(tipoSaluto, punteggiatura);

        saluto += $"\nGioco nei {Squadra} col numero {Numero}";

        return saluto;

    }
}