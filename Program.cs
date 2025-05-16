using cs_oop.Models;


// polimorfismo
// significa "molte forme"
// la classe derivata è ANCHE la classe base
// es: un Abbonato è un Abbonato, ma ANCHE uno Spettatore, ma ANCHE una Persona
Cestista lebron = new Cestista("Lebron", "James", new DateTime(1984, 12, 30), "L.A. Lakers", 6);
Console.WriteLine(lebron.Saluta("Ciao"));
Console.WriteLine($"{lebron.NomeCompleto} tipo: {lebron.GetType()}");
Console.WriteLine($"{lebron.NomeCompleto} è Cestista: {lebron is Cestista}");
Console.WriteLine($"{lebron.NomeCompleto} è Persona: {lebron is Persona}");
Console.WriteLine($"{lebron.NomeCompleto} è DateTime: {lebron is DateTime}");

Abbonato alessia = new Abbonato("Alessia", "Marrone", new DateTime(1998, 2, 3), "A23", "XYZ000XYZ");
Console.WriteLine($"{alessia.NomeCompleto} tipo: {alessia.GetType()}");
Console.WriteLine($"{alessia.NomeCompleto} è Cestista: {alessia is Cestista}");
Console.WriteLine($"{alessia.NomeCompleto} è Abbonato: {alessia is Abbonato}");
Console.WriteLine($"{alessia.NomeCompleto} è Spettatore: {alessia is Spettatore}");
Console.WriteLine($"{alessia.NomeCompleto} è Persona: {alessia is Persona}");

// polimorfismo usate nei aprametri di funzione
var kerr = new Allenatore("Steve", "Kerr", new DateTime(1965, 9, 27), "GSW");
Console.WriteLine(kerr.Rimprovera(lebron));
Console.WriteLine(kerr.Rimprovera(alessia));

var mario = new Persona("Mario", "Rossi", new DateTime(2000, 5, 6));
Console.WriteLine(kerr.Rimprovera(mario));