Campeonato? c1 = null;
List<Jogador> jogadores = new();
List<Equipe> equipes = new();

bool loop = true;
Jogador jogador;
bool partida = false;

while (loop)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Criar Jogador");
    Console.WriteLine("2. Criar Equipe");
    Console.WriteLine("3. Adicionar Jogador a uma Equipe");
    Console.WriteLine("4. Iniciar Partida");
    Console.WriteLine("5. Visualizar Classificação");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            //Criar jogador
            Console.WriteLine("Digite o nome: ");
            string? nome = Console.ReadLine();
            Console.WriteLine("Digite o nickname: ");
            string? nickname = Console.ReadLine();

            jogador = new Jogador { nome = nome!, nickname = nickname! };
            jogadores.Add(jogador);
            break;
        case 2:
            //Criar equipe
            Console.WriteLine("Digite o nome da equipe: ");
            string nomeEquipe = Console.ReadLine()!;

            Equipe equipe = new Equipe(nomeEquipe, new List<Jogador>());
            equipes.Add(equipe);
            break;
        case 3:
            //Adicionar jogador
            Console.WriteLine("Insira o numero da equipe: (0 ou 1)");
            int eq = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Insira o numero do jogador: (0 a 9)");
            int jg = int.Parse(Console.ReadLine()!);

            if (equipes[eq].Jogadores.Count < 5)
            {
                equipes[eq].adicionarJogador(jogadores[jg]);
            }
            else
            {
                Console.WriteLine("\nA equipe já tem 5 jogadores. Não é possível adicionar mais.");
            }
            break;
        case 4:
            //Iniciar partida
            Console.WriteLine("Insira o nome do campeonato: ");
            string cmpNome = Console.ReadLine()!;
            if (equipes.Count == 2)
            {

                if (equipes[0].Jogadores.Count == 5 && equipes[1].Jogadores.Count == 5)
                {
                    c1 = new(cmpNome, equipes[0], equipes[1]);
                    c1.IniciarPartida(equipes[0], equipes[1]);
                    partida = true;
                }
                else
                {
                    Console.WriteLine("\nCada equipe deve ter exatamente 5 jogadores para iniciar uma partida.");
                }
            }
            else
            {
                Console.WriteLine("\nNecessário ter duas equipes para iniciar uma partida.");
            }

            break;
        case 5:
            //visualizar classificação
            if (partida)
            {
                c1!.Classificacao();
            }
            else
            {
                Console.WriteLine("\nNecessário iniciar uma partida primeiro para visualizar as classificações.");
            }
            break;
        case 0:
            //Sair
            loop = false;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}