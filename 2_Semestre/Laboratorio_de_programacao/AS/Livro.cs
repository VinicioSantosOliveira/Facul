public class Livro : ItemBiblioteca
{
    public string autor { get; set; }
    public Livro (int id, string titulo, string autor, string DescricaoInterna) : base (id, titulo)
    {
        this.autor = autor;
        descricaoInterna = DescricaoInterna;
    }
    public void ExibirDescricaoInterna(){
        Console.WriteLine($"A descrição do livro desejado é {descricaoInterna}"); 
    }
}