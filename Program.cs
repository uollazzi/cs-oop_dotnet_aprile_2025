using cs_oop.Interfaces;
using cs_oop.Models;

// interfaccia
// definisce un contratto (un insieme di regole)
// qualsiasi classe che implementa (aderisce) tale contratto
// deve fornire un'implementazione dei membri definiti dall'interfaccia
var lebron = new Cestista("Lebron", "James", new DateTime(1984, 12, 30), "L.A. Lakers", 6);
var alessia = new Abbonato("Alessia", "Marrone", new DateTime(1998, 2, 3), "A23", "XYZ000XYZ");
var kerr = new Allenatore("Steve", "Kerr", new DateTime(1965, 9, 27), "Golden State Warriors");



// interfaccia come tipo di parametro
void Trasferisci(ITrasferibile persona, string squadra)
{
    persona.TrasferiscimiA(squadra);
}

Console.WriteLine(lebron.Saluta("Addio"));
Trasferisci(lebron, "Chicago Bulls");
Console.WriteLine(lebron.Saluta("Salve"));

Console.WriteLine(kerr.Saluta("Addio"));
Trasferisci(kerr, "Boston Celtics");
Console.WriteLine(kerr.Saluta("Salve"));

// Trasferisci(alessia, "Boston Celtics"); // ERRORE
void Esonera(IEsonerabile persona, DateTime dataEsonero)
{
    persona.Esonerami(dataEsonero);
}

Console.WriteLine("Data ultimo esonero: " + (kerr.DataUltimoEsonero.HasValue ? kerr.DataUltimoEsonero.Value.ToShortDateString() : "MAI"));
Console.WriteLine("Squadra: " + kerr.Squadra);
Esonera(kerr, DateTime.Now);
Console.WriteLine("Data ultimo esonero: " + kerr.DataUltimoEsonero);
Console.WriteLine("Squadra: " + kerr.Squadra);

// esempio interfaccia del framework
// IEnumerable
void StampaLista(IEnumerable<string> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}

List<string> l = new List<string>() { "ciao", "come", "stai" };
string[] a = new string[] { "molto", "bene", "grazie" };

StampaLista(l);
StampaLista(a);