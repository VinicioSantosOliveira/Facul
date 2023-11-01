class Equipe
{
    public string nomeEquipe;
    public List<Jogador> Jogadores;

    public Equipe(string nome, List<Jogador> jogadores)
    {
        this.nomeEquipe = nome;
        this.Jogadores = jogadores;
    }

    public int PontosTotal()
    {
        int totalPontos = 0;
        foreach (Jogador jogador in Jogadores)
        {
            totalPontos += jogador.pontos;
        }
        return totalPontos;
    }

    //int numJogadores = 0;

    public void adicionarJogador(Jogador j)
    {
        Jogadores.Add(j);
        //numJogadores++;
    }
}