// Exercício 6: Classe Data
// Classe: Data
// Atributos: dia, mes, ano
// Método: ImprimirDataFormatada()
// Descrição: Crie um método que imprima a data formatada armazenada nos atributos.

class Data
{
    public int dia;
    public int mes;
    public int ano;

    public void imprimirDataFormatada() {
        Console.WriteLine($"{dia}/{mes}/{ano}");
    }
}