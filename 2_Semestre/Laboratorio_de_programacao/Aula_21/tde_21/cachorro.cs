class Cachorro : Animal, InterAnimal
{
    public override void FazerSom()
    {
        Console.WriteLine("Cachorro fez som.");
    }

    public void save()
    {
        Console.WriteLine("Cachorro salvado");
    }
}