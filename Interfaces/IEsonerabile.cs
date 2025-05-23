namespace cs_oop.Interfaces;

public interface IEsonerabile
{
    void Esonerami(DateTime dataEsonero);

    DateTime? DataUltimoEsonero { get; }
}