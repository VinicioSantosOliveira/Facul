//1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato:
//Aluno tem anos e nota usando a concatenação e a interpolação de strings.

string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

//2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

Console.WriteLine($"Aluno {nome} \ntem {idade} anos \ne nota {nota}");

//3- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
//a concatenação e também a interpolação de string

Console.WriteLine("Informe uma letra: ");
string? letra1 = Console.ReadLine();
Console.WriteLine("Informe outra letra: ");
string? letra2 = Console.ReadLine();
Console.WriteLine("Informe outra letra: ");
string? letra3 = Console.ReadLine();

Console.WriteLine($"{letra3},{letra2},{letra1}");

//4- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
//exibindo o resultado

Console.WriteLine("Informe um valor do tipo decimal: ");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe outro valor do tipo decimal: ");
double valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nSoma de x + y = {valor1 + valor2}");
Console.WriteLine($"Subtraçao de x - y = {valor1 - valor2}");
Console.WriteLine($"Multiplicaçao de x * y = {valor1 * valor2}");

double divisao = (double)valor1 / valor2;

Console.WriteLine($"Divisao de x / y = {divisao}");
Console.WriteLine($"Resto da divisao de x % y = {valor1 % valor2}");
Console.WriteLine($"A potencia de x = {Math.Pow(valor1, valor2)}");

//5- Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
//a b e c .
//Valores : a = 1 , b = 12 e c = -13

double a = 1;
double b = 12;
double c = -13;

double delta = (b * b) - (4 * a * c);

if (delta < 0)
{
    Console.WriteLine("A equação não possui raízes reais.");
}
else if (delta == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"A equação possui uma raiz real: x = {x}");
}
else
{
    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"A equação possui duas raízes reais: x1 = {x1} e x2 = {x2}");
}

/*6 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
inválido’: (use o operador condicional ternário)*/

Console.WriteLine("Informe o nome do Login: ");
string? nomeLogin = Console.ReadLine();
Console.WriteLine("Informe a senha do Login: ");
int senhaLogin = Convert.ToInt32(Console.ReadLine());

string nome1 = "admin";
string nome2 = "maria";
int senha = 123;

string resultado = (nomeLogin == nome1 || nomeLogin == nome2) && (senhaLogin == senha)? "Login feito com sucesso" :
"Login inválido";

Console.WriteLine(resultado);

//7 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Informe o valor de x: ");
int xx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y: ");
int yy = Convert.ToInt32(Console.ReadLine());

string resultX = (xx % 2 == 0)? "x é par" : "x é impar";
Console.WriteLine(resultX);

string resultY = (yy % 2 == 0)? "y é par" : "y é impar";
Console.WriteLine(resultY);