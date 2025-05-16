using cs_oop.Models;

namespace cs_oop;

// implementiamo l'incapsulamento attraverso
// il livello di accessibilità della classe e dei suoi membri
// public               accesso consentito a tutti
// protected            accesso limitato alla classe che lo contiene o ai tipi che derivano dalla classe che lo contiene
// internal             accesso limitato all'assemply (~ libreria) corrente
// protected internal	accesso limitato all'assembly (~ libreria) corrente o ai tipi che derivano dalla classe che lo contiene
// private              accesso limitato alla classe che lo contiene
// private protected	accesso limitato alla classe che lo contiene o ai tipi che derivano dalla classe che lo contiene all'interno all'assemply (~ libreria) corrente
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

// assembly: unità fondamentali di pubblicazione e riuso nelle applicazioni .NET
//           possono assumere forma di files: .exe o .dll


class Program
{
    static void Main(string[] args)
    {
        var mario = new Persona();
        mario.Nome = "Mario";
        mario.Cognome = "Rossi";

        Console.WriteLine(mario.Nome);
        Console.WriteLine(mario.Cognome);

        var anna = new Persona();
        anna.Nome = "Anna";
        anna.Cognome = "Verdi";
        Console.WriteLine(anna.Id);

        Console.WriteLine($"Nascita Mario {mario.DataNascita}");

        var nascitaAnna = new DateTime(2000, 1, 12);
        anna.DataNascita = nascitaAnna;

        Console.WriteLine($"Nascita Anna {anna.DataNascita}");

        Console.WriteLine(mario.NomeCompleto);

        Console.WriteLine($"Anna ha {anna.Anni} anni");

        Console.WriteLine(mario.Saluta("Ciao", "😁😁😁😁"));
        Console.WriteLine(anna.Saluta("Salve"));

        var oggi = DateTime.Now; // Now = proprietà statica
        var data = new DateTime(2025, 1, 1);

        Console.WriteLine(Persona.CosaSono());

        // assegnazione veloce dei valori delle proprietà
        // in fase di istanziamento
        var indirizzo = new Indirizzo()
        {
            Via = "Via della Libertà",
            Civico = "456",
            CAP = "80987",
            Provincia = "NA",
            Citta = "Procida",
            Stato = "Italia"
        };
        anna.Indirizzo = indirizzo;

        Console.WriteLine(anna.Indirizzo?.Citta);

        anna.IMieiAnimali.Add(new Animale());


    }
}