/*6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o
valor 7.80 e exiba o seu valor.*/

double? nota = 7.80;

if (nota != null)
{
    Console.WriteLine(nota);
}
else
{
    Console.WriteLine("a variavel nota é null");
}