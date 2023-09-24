// operadores aritmeticos

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Soma de x + y = {x + y}");
Console.WriteLine($"Subtraçao de x - y = {x - y}");
Console.WriteLine($"Multiplicaçao de x * y = {x * y}");

double divisao = (double) x / y;

Console.WriteLine($"Divisao de x / y = {divisao}");
Console.WriteLine($"Resto da divisao de x % y = {x % y}");

Console.WriteLine($"A raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"A potencia de x = {Math.Pow(x, y)}");
Console.WriteLine($"O valor minimo entre x e y é = {Math.Min(x, y)}");

//---------------------------------------------------

//Operadores de atribuiçao

double z = 10;

Console.WriteLine($"O valor atual de x {z}");
Console.WriteLine($"x += 5 -> {z +=5}");

Console.WriteLine($"O valor atual de x {z}");
Console.WriteLine($"x -= 5 -> {z -=5}");

//---------------------------------------------------

//Operadores de incremento e decremento
int a = 0;

//Pre-Incremento
int resultado = ++a;
Console.WriteLine(resultado);
Console.WriteLine(a);

//---------------------------------------------------

//operadores relacionais

int w = 10;
int u = 20;

Console.WriteLine(w == u);
Console.WriteLine(w > u);
Console.WriteLine(w < u);
Console.WriteLine(w >= u);
Console.WriteLine(w == u);
Console.WriteLine(w != u);

//---------------------------------------------------

//Operadores Logicos

//bool c1 = true;
//bool c2 = false;
//bool result;

//operador and

//resultado = c1 && c2;
//Console.WriteLine(result);

//Operador or

//resultado = c1 || c2;
//Console.WriteLine(result);

//Operador not
//resultado = !c2
//Console.WriteLine(result);

//Operador ternario (tipo If e Else)
//condiçao ? valorSerVerdadeiro : ValorSerFalso

int numero = 5;
String resultadoTernario = (numero % 2 == 0)? "Par" : "Impar";
Console.WriteLine(resultadoTernario);

//constantes (nao é possivel alterar o valor durante o programa)
//const double pi = 3.14;