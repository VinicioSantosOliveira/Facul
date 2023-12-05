Biblioteca minhaBiblioteca = new();

Livro l1 = new("Guanabara", 1, "Curso de Poo");
Livro l2 = new("Jacob", 1, "Curso de Flutter");

minhaBiblioteca.adicionarLivro(l1);



























// bool loop = true;
// List<Livro> listLivros = new();
// Livro livro = null!;
// int id = 0;

// do
// {
//     Console.WriteLine("---------MENU---------");
//     Console.WriteLine("1 = Adicionar livro");
//     Console.WriteLine("2 = Remover livro");
//     Console.WriteLine("3 = Buscar livro");
//     Console.WriteLine("4 = Sair");
//     int opcao = Convert.ToInt32(Console.ReadLine());

//     switch (opcao)
//     {
//         case 1:
//             Console.WriteLine("Informe o autor do livro: ");
//             string autor = Console.ReadLine()!;

//             // id++;

//             // Console.WriteLine("Informe o autor do livro: ");
//             // string autor = Console.ReadLine()!;
//             // Console.WriteLine("Informe o titulo do livro: ");
//             // string titulo = Console.ReadLine()!;

//             // livro = new(autor, id, titulo);
//             // listLivros.Add(livro);
//             break;
//         case 2:
//             Console.WriteLine("Informe o id do livro que deseja remover: ");
//             int idRemoverLivro = Convert.ToInt32(Console.ReadLine()!);

            
//             break;
//         case 3:
//             Console.WriteLine("Informe o nome do livro que deseja buscar: ");
//             string buscarLivro = Console.ReadLine()!;

//             Livro livroBuscado = listLivros.Find(livro => livro.titulo == buscarLivro)!;

//             if (livroBuscado != null)
//             {
//                 Console.WriteLine($"Livro encontrado com sucesso: {livroBuscado.titulo}.");
//             }
//             else
//             {
//                 Console.WriteLine($"Livro nao encontrado.");
//             }
//             break;
//         case 4:
//             Console.WriteLine("Saindo..");
//             loop = false;
//             break;
//         default:
//             Console.WriteLine("Digite uma opção válida");
//             break;
//     }
// } while (loop);