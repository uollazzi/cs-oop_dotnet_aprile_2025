namespace cs_oop.Models;

public abstract class Animale
{
    public void Dormi()
    {
        Console.WriteLine("Zzzz");
    }

    // membro astratto
    // membro di cui si DEVE fare l'override
    public abstract void EmettiSuono();
}