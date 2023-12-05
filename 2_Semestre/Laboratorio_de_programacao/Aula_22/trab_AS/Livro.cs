class Livro : ItemBiblioteca
{
    public string autor;

    public Livro(string autor, int id, string titulo) : base(id, titulo)
    {
        this.autor = autor;
        this.id = id;
        this.titulo = titulo;
        this.descricaoInterna = $"Autor: {autor}, Id: {id}, Titulo: {titulo}.";
    }
    
    public void exibirDescricaoInterna()
    {
        Console.WriteLine(descricaoInterna);
    }
}