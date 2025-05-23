using CsvHelper;
using cs_oop.Models;
using System.Globalization;

// librerie esterne
using var reader = new StreamReader("persone.csv");
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);