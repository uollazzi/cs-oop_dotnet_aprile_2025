using cs_oop.Models;

// ereditarietà
// L'ereditarietà consente di creare nuove classi che
// riutilizzano, estendono e modificano il comportamento definito in altre classi

// la classe i cui membri vengono ereditati (quella da cui si parte) si chiama classe base
// mentre la classe che eredita (da quella base) si chiama derivata

// una classe derivata può avere SOLO UNA classe base diretta
// l'ereditarietà, tuttavia, è transitiva (casa => casa di legno => baita (casa di legno in montagna))

// l'unica cosa che la derivata non eredita dalla base è il costruttore

Cestista lebron = new Cestista()
{
    Nome = "Lebron",
    Cognome = "James",
    DataNascita = new DateTime(1984, 12, 30)
};
Console.WriteLine(lebron.Saluta("Ciao"));

lebron.Squadra = "L.A. Lakers";
lebron.Numero = 23;
lebron.ValoreSchiacciata = 95;
Console.WriteLine(lebron.Schiaccia() ? "Successo" : "Fallimento");

var kd = new Cestista("Kevin", "Durant", new DateTime(1988, 9, 29), "Brooklin Nets", 7);
Console.WriteLine(kd.Saluta("Salve"));

var nicola = new Spettatore("Nicola", "Bianchi", new DateTime(2020, 1, 1), "B45");
Console.WriteLine(nicola.NumeroPostoASedere);

var alessia = new Abbonato("Alessia", "Verdi", new DateTime(1998, 5, 6), "A23", "XYZ9999");
Console.WriteLine(alessia.Saluta("Ciao"));
Console.WriteLine($"Abbonamento: {alessia.CodiceAbbonamento}, Posto: {alessia.NumeroPostoASedere}");

lebron.PartiteVinte = 199;

// eccezioni custom (ereditiamo da Exception)
// o anche da altre Exception più specifiche
try
{
    if (nicola.Anni < 18)
        throw new MinorenneException();
}
catch (MinorenneException ex)
{
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
}