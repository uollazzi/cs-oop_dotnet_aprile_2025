using CsvHelper;
using cs_oop.Models;
using System.Globalization;

// librerie esterne
using var reader = new StreamReader("persone.csv");
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var persone = csv.GetRecords<Persona>().ToList();

Console.WriteLine("Persone totali: " + persone.Count);
Console.WriteLine($"Prima persona: {persone[0]}");

Console.WriteLine("Elenco utenti del file persone.csv");
foreach (var p in persone)
{
    Console.WriteLine(p.ToString());
}