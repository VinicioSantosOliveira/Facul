// Console.WriteLine("Digite um numero: ");
// double num = Convert.ToDouble(Console.ReadLine());

// if (num > 0) {
//     Console.WriteLine("Numero é positivo");
// }
// else {
//     Console.WriteLine("Numero é negativo");
// }

// //--------------------------------------------

// Console.WriteLine("Digite um numero inteiro: ");
// int numInt = Convert.ToInt32(Console.ReadLine());

// if (numInt % 2 == 0) {
//     Console.WriteLine("Numero é par");
// }
// else {
//     Console.WriteLine("Numero é impar");
// }

// //--------------------------------------------

// Console.WriteLine("Digite a Media: ");
// double media = Convert.ToDouble(Console.ReadLine());

// if (media >= 9) {
//     Console.WriteLine("Parabéns");
// }
// else if (media >= 7) {
//     Console.WriteLine("Bom trabalho");
// }
// else if (media >= 6) {
//     Console.WriteLine("Aprovado na media");
// }
// else {
//     Console.WriteLine("Reprovado");
// }

//--------------------------------------------

// Console.WriteLine("Digite sua altura: ");
// double altura = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Digite seu peso: ");
// int peso = Convert.ToInt32(Console.ReadLine());

// double imc = peso /(altura * altura);

// Console.WriteLine($"Seu imc é: {imc}");

// if (imc <= 18.5)
// {
//     Console.WriteLine("Abaixo do peso");
// }
// else if (imc >= 18.5 && imc <= 24.9)
// {
//     Console.WriteLine("Peso ideal, Parabéns");
// }
// else if (imc >= 25 && imc <= 29.9)
// {
//     Console.WriteLine("Levemente acima do peso");
// }
// else if (imc >= 30 && imc <= 34.9)
// {
//     Console.WriteLine("Obesidade grau I");
// }
// else if (imc >= 35 && imc <= 39.9)
// {
//     Console.WriteLine("Obesidade grau II(Severa)");
// }
// else
// {
//     Console.WriteLine("Obesidade grau III(Morbida)");
// }

//--------------------------------------------

//Switch case

Console.WriteLine("Informe um numero de 1 a 7 representando os dia da semana: ");
int dia = Convert.ToInt32(Console.ReadLine());

switch (dia)
{
    case 1:
    Console.WriteLine("Domingo");
    break;
    case 2:
    Console.WriteLine("Segunda");
    break;
    case 3:
    Console.WriteLine("Terça");
    break;
    case 4:
    Console.WriteLine("Quarta");
    break;
    case 5:
    Console.WriteLine("Quinta");
    break;
    case 6:
    Console.WriteLine("Sexta");
    break;
    case 7:
    Console.WriteLine("Sabado");
    break;
    default:
    Console.WriteLine("Numero invalido");
    break;
}

//--------------------------------------------

Console.WriteLine("Informe seu estado civil\n(S - solteiro, C - casado, D - divorciado, V - viúvo): ");
char estadoCivil = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

switch (estadoCivil)
{
    case 'S':
    Console.WriteLine("Voce esta solteiro");
    break;
    case 'C':
    Console.WriteLine("Voce esta casado");
    break;
    case 'D':
    Console.WriteLine("Voce esta divorciado");
    break;
    case 'V':
    Console.WriteLine("Voce esta viúvo");
    break;
    default:
    Console.WriteLine("Letra informada nao reconhecido");
    break;
}