//1. Escreva um programa que leia um número do usuário e determine se ele é positivo, negativo ou zero.

Console.WriteLine("Informe um numero: ");
double n = Convert.ToDouble(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine("Positivo");
}
else if (n < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Zero");
}

//2. Peça ao usuário para inserir um número de 1 a 7. Seu programa deve exibir o dia da semana correspondente,
//onde 1 é domingo e 7 é sábado. Se o número estiver fora desse intervalo, exiba uma mensagem de erro.

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

//3. Crie um programa que leia a idade do usuário e categorize-a nas seguintes faixas etárias:
// Criança (0-12 anos)
// Adolescente (13-18 anos)
// Adulto (19-59 anos)
// Idoso (60 anos ou mais)

Console.WriteLine("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade > 0 && idade <= 12)
{
    Console.WriteLine("Criança");
}
else if (idade >= 13 && idade <= 18)
{
    Console.WriteLine("Adolescente");
}
else if (idade >= 19 && idade <= 59)
{
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Idoso");
}

//4. Peça ao usuário para inserir um ano e determine se é um ano bissexto ou não.

Console.WriteLine("Informe um ano: ");
int ano = Convert.ToInt32(Console.ReadLine());

if (ano % 4 == 0)
{
    Console.WriteLine($"O ano {ano} informado é bissexto");
}
else{
    Console.WriteLine("O ano informado nao é bissexto");
}

//5. Escreva um programa que peça ao usuário dois números e uma operação (soma, subtração, multiplicação, divisão).
//Use uma estrutura switch para realizar a operação escolhida e exiba o resultado.

Console.WriteLine("Informe um numero: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe outro numero: ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe abaixo qual operação deseja realizar entre os dois numeros informados acima: ");
Console.WriteLine("1 - soma\n2 - subtração\n3 - multiplicação\n4- divisão");
int operador = Convert.ToInt32(Console.ReadLine());

switch (operador)
{
    case 1:
        Console.WriteLine($"A soma entre {n1} e {n2} é: {n1 + n2}");
        break;
    case 2:
        Console.WriteLine($"A subtração entre {n1} e {n2} é: {n1 - n2}");
        break;
    case 3:
        Console.WriteLine($"A multiplicação entre {n1} e {n2} é: {n1 * n2}");
        break;
    case 4:
        Console.WriteLine($"A divisão entre {n1} e {n2} é: {n1 / n2}");
        break;
    default:
        Console.WriteLine("Erro");
        break;
}

//6. Solicite ao usuário que insira uma nota (0-100). Classifique a nota nas seguintes categorias:
// A (90-100)
// B (80-89)
// C (70-79)
// D (60-69)
// F (0-59)

Console.WriteLine("Informe uma nota entre 0 e 100: ");
int nota = Convert.ToInt32(Console.ReadLine());

if (nota >= 0 && nota <= 59)
{
    Console.WriteLine("F");
}
else if (nota >= 60 && nota <= 69)
{
    Console.WriteLine("D");
}
else if (nota >= 70 && nota <= 79)
{
    Console.WriteLine("C");
}
else if (nota >= 80 && nota <= 89)
{
    Console.WriteLine("B");
}
else if (nota >= 90 && nota <= 100)
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine("Nota informado incorretamente");
}

//7. Peça ao usuário para inserir um número de 1 a 12. Exiba o mês correspondente ao número.
//Se o número estiver fora desse intervalo, mostre uma mensagem de erro.

Console.WriteLine("Informe um numero de 1 a 12 representando os meses do ano: ");
int mes = Convert.ToInt32(Console.ReadLine());

switch (mes)
{
    case 1:
    Console.WriteLine("janeiro");
    break;
    case 2:
    Console.WriteLine("fevereiro");
    break;
    case 3:
    Console.WriteLine("março");
    break;
    case 4:
    Console.WriteLine("abril");
    break;
    case 5:
    Console.WriteLine("maio");
    break;
    case 6:
    Console.WriteLine("junho");
    break;
    case 7:
    Console.WriteLine("julho");
    break;
    case 8:
    Console.WriteLine("agosto");
    break;
    case 9:
    Console.WriteLine("setembro");
    break;
    case 10:
    Console.WriteLine("outubro");
    break;
    case 11:
    Console.WriteLine("novembro ");
    break;
    case 12:
    Console.WriteLine("dezembro");
    break;
    default:
    Console.WriteLine("ERRO 404\nNumero fora do intervalo");
    break;
}

//8. Solicite ao usuário que insira três números. Determine e exiba o maior deles.

Console.WriteLine("Informe um numero: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe outro numero: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe mais um numero: ");
double num3 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"O numero {num1} é maior valor");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"O numero {num2} é maior valor");
}
else
{
    Console.WriteLine($"O numero {num3} é maior valor");
}

//9. Crie um programa que determine a tarifa de ônibus a ser paga pelo usuário com base em sua idade. As tarifas são:
// Crianças até 5 anos: grátis
// Crianças de 6 a 12 anos: 50% de desconto
// Adultos de 13 a 59 anos: tarifa completa
// Idosos (60 anos ou mais): grátis

Console.WriteLine("Informe sua idade: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age <= 5)
{
    Console.WriteLine("grátis");
}
else if (age >= 6 && age <= 12)
{
    Console.WriteLine("50% de desconto");
}
else if (age >= 13 && age <= 59)
{
    Console.WriteLine("tarifa completa");
}
else
{
    Console.WriteLine("grátis");
}

//10. Peça ao usuário para inserir uma temperatura. Classifique e exiba a seguinte mensagem:
// Abaixo de 0: “Congelando!”
// 0 a 15: “Frio!”
// 16 a 25: “Clima agradável!”
// 26 a 35: “Calor!”
// Acima de 35: “Muito quente!”

Console.WriteLine("Informe a temperatura: ");
double temperatura = Convert.ToDouble(Console.ReadLine());

if (temperatura < 0)
{
    Console.WriteLine("Congelando!");
}
else if (temperatura >= 0 && temperatura <= 15)
{
    Console.WriteLine("Frio!");
}
else if (temperatura >= 16 && temperatura <= 25)
{
    Console.WriteLine("Clima agradável!");
}
else if (temperatura >= 26 && temperatura <= 35)
{
    Console.WriteLine("Calor!");
}
else
{
    Console.WriteLine("Muito quente!");
}