//Exercício 1: Soma de Números de 1 a 10
//Escreva um programa que utilize um loop for para calcular e exibir na tela a soma dos números inteiros de 1 a 10.
//Mostre o resultado final após o loop.

// int total = 0;
// for (var i = 0; i <= 10; i++)
// {
//     total = total + i;
// }

// Console.WriteLine(total);


//Exercício 2: Contagem Regressiva com while
//Crie um programa que use um loop while para realizar uma contagem regressiva a partir de 10 até 0.
//A cada iteração, o programa deve exibir o número atual no console.

// int x = 11;
// do
// {
//     x--;
//     Console.WriteLine(x);
// } while (x > 0);

//Exercício 3: Pular Números Ímpares
//Desenvolva um programa que utilize um loop for e a palavra-chave continue para imprimir todos os números pares entre 1 e 20.
//Evite imprimir os números ímpares.

// for (var i = 0; i <= 20; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     else
//     {
//         continue;
//     }
// }

//Exercício 4: Sair Quando o Quadrado For Maior que 50
//Escreva um programa que utilize um loop while e a palavra-chave break.
//O programa deve calcular os quadrados dos números inteiros começando com 1 e parar assim que um quadrado maior que 50 for encontrado.
//Exiba esse valor no console.

int numero = 1;
do
{
    int quadrado = numero * numero;
    numero++;
    Console.WriteLine(quadrado);

    if (quadrado > 50)
    {
        break;
    }
} while (true);

//Exercício 5: Tabuada de um Número Usando for
//Crie um programa que solicite ao usuário um número inteiro. Utilize um loop for para imprimir a tabuada desse número, de 1 a 10.
//Mostre cada linha da tabuada no console.



//Exercício 6: Soma com Loop do-while
//Desenvolva um programa que utilize um loop do-while para solicitar números inteiros ao usuário.
//Continue somando esses números até que o usuário insira o número 0. Mostre a soma total ao final.


//Exercício 7: Encontrar o Primeiro Múltiplo de 3 e 7
//Utilize um loop for e a palavra-chave break para procurar o primeiro número que seja múltiplo tanto de 3 quanto de 7,
//dentro do intervalo de 1 a 100. Exiba esse número no console.

//Exercício 8: Fatorial de um Número
//Peça ao usuário para inserir um número inteiro positivo. Utilize um loop for para calcular o fatorial desse número.
//Exiba o resultado no console.


