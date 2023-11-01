Livro l1 = new();
Livro l2 = new();
Livro l3 = new();
l1.titulo = "Harry Potter";
l1.autor = "Dumblodore";
l1.disponivel = true;

l2.titulo = "Liga da justiça";
l2.autor = "DC";
l2.disponivel = false;

l3.titulo = "Homem aranha";
l3.autor = "Marvel";
l3.disponivel = true;

Biblioteca b1 = new();
b1.nome = "Biblistore";
b1.AdicionarLivro(l1);
b1.AdicionarLivro(l2);
b1.AdicionarLivro(l3);

Livro result = b1.BuscarPorTipo("Homem aranha");
Console.WriteLine(result.titulo);