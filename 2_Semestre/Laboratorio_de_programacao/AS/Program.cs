Livro l1 = new Livro(1, "O Iluminado", "Stephen King", "Terror e Drama");

Livro l2 = new Livro(2, "O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Aventura");

Livro l3 = new Livro(3, "O Estrangeiro", "Albert Camus", "Misterio e Terror");

Biblioteca b1 = new Biblioteca();
b1.AdicionarItem(l1);
b1.AdicionarItem(l2);
b1.AdicionarItem(l3);

ItemBiblioteca? LivroEncontradoPorTitulo = b1.BuscarItem("O Iluminado");
if(LivroEncontradoPorTitulo != null)
{
    Livro livroEncontrado = (Livro)LivroEncontradoPorTitulo;
    livroEncontrado.ExibirDescricaoInterna();
}

ItemBiblioteca? LivroEncontradoPorId = b1.BuscarItem(1); // Busca Livro pelo id
if(LivroEncontradoPorId != null)
{
    Livro livroEncontrado = (Livro)LivroEncontradoPorId;
    livroEncontrado.ExibirDescricaoInterna(); // Mostra a descrição do livro buscado pelo Titulo
}

b1.RemoverItem(l1);
b1.RemoverItem(l2);
b1.RemoverItem(l3);