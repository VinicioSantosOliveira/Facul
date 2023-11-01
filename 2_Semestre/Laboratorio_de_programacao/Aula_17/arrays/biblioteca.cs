class Biblioteca
{
    public string? nome;
    public Livro[] arrayLivros = new Livro[3];

    public void AdicionarLivro(Livro l)
    {
        for (int i = 0; i <= arrayLivros.Length; i++)
        {
            if (arrayLivros[i] == null)
            {
                arrayLivros[i] = l;
                break;
            }
        }
    }
    public Livro BuscarPorTipo(string lTitulo)
    {
        for (int i = 0; i <= arrayLivros.Length; i++)
        {
            if (arrayLivros[i].titulo == lTitulo)
            {
                return arrayLivros[i];
            }
        }
        Console.WriteLine("Livro nao encontrado");
        return null!;
    }
}