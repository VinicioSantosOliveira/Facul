// Exercício 1: Classe Pessoa
// Crie uma classe Pessoa com os atributos nome, idade e cidadeNatal. Inicialize um objeto desta classe e exiba seus atributos no console.

Pessoa p1 = new Pessoa();

p1.nome = "vinicio";
p1.idade = 21;
p1.cidadeNatal = "Torres";

Console.WriteLine($"nome: {p1.nome}\nidade: {p1.idade}\ncidade natal: {p1.cidadeNatal}");

class Pessoa
{
    public string? nome;
    public int idade;
    public string? cidadeNatal;
}

// Exercício 2: Classe Produto
// Desenvolva uma classe chamada Produto que contenha os atributos nome, preco e categoria.
// Crie um objeto desta classe e imprima seus atributos na tela.

// Produto produto = new Produto();
// produto.nome = "Amaciante";
// produto.preco = 15;
// produto.categoria = "Limpeza";

// Console.WriteLine($"produto: {produto.nome}\npreço: {produto.preco}\ncategoria: {produto.categoria}");

// class Produto
// {
//     public string? nome;
//     public double preco;
//     public string? categoria;
// }

// Exercício 3: Classe Animal
// Implemente uma classe Animal com os atributos especie, nome e idade.
// Inicialize dois objetos desta classe com diferentes atributos e exiba-os no console.

// Animal dog = new Animal();
// dog.especie = "cachorro";
// dog.nome = "toto";
// dog.idade = 5;

// Console.WriteLine($"Especie: {dog.especie}\nNome: {dog.nome}\nIdade: {dog.idade}");

// class Animal
// {
//     public string? especie;
//     public string? nome;
//     public int idade;
// }

// Exercício 4: Classe Curso
// Crie uma classe Curso com os atributos nome, duracao e professor.
// Crie três objetos desta classe e imprima suas informações no console.

// Curso curso1 = new Curso();
// curso1.nome = "Lpu";
// curso1.duracao = 6;
// curso1.professor = "Fogaça";

// Console.WriteLine($"Nome do curso: {curso1.nome}\nDuração: {curso1.duracao} meses\nProfessor: {curso1.professor}");

// class Curso
// {
//     public string? nome;
//     public int duracao;
//     public string? professor;
// }

// Exercício 5: Diferentes Atributos
// Utilizando a classe Carro criada durante a aula, instancie três objetos diferentes e exiba suas propriedades no console.

// Carro carro1 = new Carro();
// carro1.cor = "cinza";
// carro1.modelo = "golf";
// carro1.ano  = 2004;

// Carro carro2 = new Carro();
// carro2.cor = "preto";
// carro2.modelo = "saveiro surf";
// carro2.ano = 2008;

// Carro carro3 = new Carro();
// carro3.cor = "branco";
// carro3.modelo = "gol";
// carro3.ano = 2015;

// Console.WriteLine($"Cor: {carro1.cor}\nModelo: {carro1.modelo}\nAno: {carro1.ano}");
// Console.WriteLine($"Cor: {carro2.cor}\nModelo: {carro2.modelo}\nAno: {carro2.ano}");
// Console.WriteLine($"Cor: {carro3.cor}\nModelo: {carro3.modelo}\nAno: {carro3.ano}");

// class Carro
// {
//     public string? cor;
//     public string? modelo;
//     public int ano;
// }

// Exercício 6: Classe Funcionário
// Desenvolva uma classe Funcionario com os atributos nome, salario e cargo. Instancie um objeto e exiba suas informações.

// Funcionario funcionario1 = new Funcionario();
// funcionario1.nome = "joao";
// funcionario1.salario = 1200;
// funcionario1.cargo = "auxiliar administrativo";

// Console.WriteLine($"Nome: {funcionario1.nome}\nSalario: {funcionario1.salario}\nCargo: {funcionario1.cargo}");

// class Funcionario
// {
//     public string? nome;
//     public int salario;
//     public string? cargo;
// }

// Exercício 7: Atributos Numéricos
// Crie uma classe Casa que possua os atributos quantidadeDeQuartos, numero e cor. Inicialize um objeto e mostre seus atributos.

// Casa casa1 = new Casa();
// casa1.quantidadeDeQuartos = 3;
// casa1.numero = 2341;
// casa1.cor = "cinza";

// Console.WriteLine($"quantidade de quartos: {casa1.quantidadeDeQuartos}\nNumero: {casa1.numero}\nCor: {casa1.cor}");

// class Casa
// {
//     public int quantidadeDeQuartos;
//     public int numero;
//     public string? cor;
// }

// Exercício 8: Classe TimeFutebol
// Crie uma classe TimeFutebol com os atributos nome, cidade e anoFundacao. Crie dois objetos com atributos diferentes e mostre-os no console.

// TimeFutebol time1 = new TimeFutebol();
// time1.nome = "Vasco";
// time1.cidade = "paraiba";
// time1.anoFundacao = 1999;

// TimeFutebol time2 = new TimeFutebol();
// time2.nome = "flamengo";
// time2.cidade = "sao paulo";
// time2.anoFundacao = 1950;

// Console.WriteLine($"Nome: {time1.nome}\nCidade: {time1.cidade}\n Ano de fundação: {time1.anoFundacao}");
// Console.WriteLine($"Nome: {time2.nome}\nCidade: {time2.cidade}\n Ano de fundação: {time2.anoFundacao}");

// class TimeFutebol
// {
//     public string? nome;
//     public string? cidade;
//     public int anoFundacao;
// }

// Exercício 9: Classe Smartphone
// Implemente uma classe Smartphone com atributos marca, modelo e anoLancamento. Inicialize um objeto dessa classe e imprima suas informações.

// Smartphone cell1 = new Smartphone();
// cell1.marca = "xiaomi";
// cell1.modelo = "redmi note 9";
// cell1.anoLancamento = 2019;

// Console.WriteLine($"Marca: {cell1.marca}\nModelo: {cell1.modelo}\nAno de lançamento: {cell1.anoLancamento}");

// class Smartphone
// {
//     public string? marca;
//     public string? modelo;
//     public int anoLancamento;
// }

// Exercício 10: Classe Filme
// Desenvolva uma classe Filme com atributos titulo, diretor e anoLancamento. Crie um objeto e mostre suas propriedades no console.

// Filme filme = new Filme();
// filme.titulo = "a vida em um ano";
// filme.diretor = "sukablyat";
// filme.anoLancamento = 2000;

// Console.WriteLine($"Titulo: {filme.titulo}\nDiretor: {filme.diretor}\nAno de lançamento: {filme.anoLancamento}");

// class Filme
// {
//     public string? titulo;
//     public string? diretor;
//     public int anoLancamento;
// }

// Exercício 12: Classe Estudante
// Desenvolva uma classe chamada Estudante com os atributos nome, curso e idade. Inicialize dois objetos desta classe e exiba suas informações.

// Estudante aluno1 = new Estudante();
// aluno1.nome = "pedro";
// aluno1.curso = "ADS";
// aluno1.idade = 30;

// Console.WriteLine($"Nome: {aluno1.nome}\nCurso: {aluno1.curso}\nIdade: {aluno1.idade}");

// class Estudante
// {
//     public string? nome;
//     public string? curso;
//     public int idade;
// }