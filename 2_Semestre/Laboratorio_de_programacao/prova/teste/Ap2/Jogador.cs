class Jogador
{
    public string? nome;
    public string? nickname;
    public int pontos = 0;

    public void Jogar()
    {
        Random random = new Random();
        int pontosDaPartida = random.Next(1, 101);
        pontos += pontosDaPartida;
    }
}