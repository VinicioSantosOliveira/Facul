// Exercício 8: Classe Tabuada
// Classe: Tabuada
// Atributos: numeroBase
// Método: ImprimirTabuada()
// Descrição: Crie um método que imprima a tabuada do numeroBase.

class Tabuada
{
    public int numeroBase;

    public void imprimirTabuada() {
        for (var i = 0; i <= 10; i++) {
            Console.WriteLine($"{numeroBase} X {i} = {numeroBase * i}");
        }
    }
}