// Exercício 2: Classe Quadrado
// Classe: Quadrado
// Atributos: numero
// Método: CalcularEImprimirQuadrado()
// Descrição: Crie um método que imprima o quadrado do número armazenado no atributo numero.

class Quadrado
{
    public int numero;
    public void calcularEImprimirQuadrado() {
        Console.WriteLine($"A raiz quadrada de numero = {Math.Sqrt(numero)}");
    }
}