using cs_oop.Models;

namespace cs_oop;

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
        Console.WriteLine(anna.Id);

        Console.WriteLine($"Nascita Mario {mario.DataNascita}");

        var nascitaAnna = new DateTime(2000, 1, 12);
        anna.DataNascita = nascitaAnna;

        Console.WriteLine($"Nascita Anna {anna.DataNascita}");

        Console.WriteLine(mario.NomeCompleto);

        Console.WriteLine($"Anna ha {anna.Anni} anni");

    }
}