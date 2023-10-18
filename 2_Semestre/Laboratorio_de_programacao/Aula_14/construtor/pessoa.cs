class Pessoa
{
    public string primeiroNome;
    public string ultimoNome;
    public string cpf;
    
    public Pessoa (string primeiro, string ultimo)
    {
        this.primeiroNome = primeiro;
        this.ultimoNome = ultimo;
    }
    
    public void status()
    {
        Console.WriteLine($"Primeiro nome: {this.primeiroNome}\nUltimo nome: {this.ultimoNome}");
    }
    public string setarCpf(string cpf)
    {
        this.cpf = cpf;
        return this.cpf;
    }
}