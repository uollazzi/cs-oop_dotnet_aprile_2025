namespace cs_oop;

using cs_oop.Models;

class Program
{
    static void Main(string[] args)
    {
        // classi
        // la classe è un progetto (template, ricetta, stampo) per creare degli oggetti

        // oggetto
        // un oggeto è un'entità reale (con cui posso interagire) che si basa su una classe
        // un oggetto viene SEMPRE creato da una classe

        // spesso ci si riferisce ad un oggetto come istanza di una classe

        // articolo intederminativo UNA persona (classe)
        // articolo determinativo LA persona che si chiama Gigi (ogetto o istanza)

        // istanzio oggetti
        Persona gigi = new Persona();
        Persona mario = new Persona();
        Persona anna = new();
        var betta = new Persona();


    }
}