class Campeonato
{
    public string nomeCampeonato;
    public Equipe equipesParticipantes1;
    public Equipe equipesParticipantes2;

    public Campeonato(string nome, Equipe ep1, Equipe ep2)
    {
        this.nomeCampeonato = nome;
        this.equipesParticipantes1 = ep1;
        this.equipesParticipantes2 = ep2;
    }
    public void IniciarPartida(Equipe e1, Equipe e2)
    {
        foreach (Jogador jogador in e1.Jogadores)
        {
            jogador.Jogar();
        }

        foreach (Jogador jogador in e2.Jogadores)
        {
            jogador.Jogar();
        }

        Console.WriteLine("Partida entre " + e1.nomeEquipe + " e " + e2.nomeEquipe + " concluída!");
    }
    public void Classificacao()
    {
        if (equipesParticipantes1.PontosTotal() > equipesParticipantes2.PontosTotal())
        {
            Console.WriteLine("1. " + equipesParticipantes1.nomeEquipe + " - Pontos totais: " + equipesParticipantes1.PontosTotal());
            Console.WriteLine("2. " + equipesParticipantes2.nomeEquipe + " - Pontos totais: " + equipesParticipantes2.PontosTotal());
        }
        else
        {
            Console.WriteLine("1. " + equipesParticipantes2.nomeEquipe + " - Pontos totais: " + equipesParticipantes2.PontosTotal());
            Console.WriteLine("2. " + equipesParticipantes1.nomeEquipe + " - Pontos totais: " + equipesParticipantes1.PontosTotal());
        }
    }
}