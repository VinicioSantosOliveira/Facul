class Gato : Animal, InterAnimal
{
    public override void FazerSom()
    {
        Console.WriteLine("Gato fez som.");
    }

    public void save()
    {
        Console.WriteLine("Gato salvado");
    }
}