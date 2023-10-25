class Carro
{
    public string marca;
    public string modelo;
    public int ano;

    //construtor com valores default caso nao haja parametros passados
    public Carro()
    {
        this.marca = "indefinido";
        this.modelo = "indefinido";
        this.ano = 2023;
    }

    public Carro(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }

    public void carroStatus()
    {
        Console.WriteLine($"marca: {this.marca}\nmodelo: {this.modelo}\nano: {this.ano}");
    }
}