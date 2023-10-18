// Exercício 4: Classe Concatenador
// Classe: Concatenador
// Métodos: Sobrecargas do método Concatenar()
// Descrição: Crie sobrecargas do método Concatenar como especificado previamente, sem utilizar atributos.

class Concatenador
{
    public string concatenar(string a, string b) {
        return a + b;
    }
    public string concatenar(string a, string b, string c) {
        return a + b + c;
    }
}