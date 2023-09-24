//11- Declare uma variável `temperatura` do tipo double como sendo do tipo Nullable type e atribua o valor 22.5 e exiba o seu valor.

double? temperatura = 22.5;

if (temperatura != null)
{
    Console.WriteLine(temperatura);
}
else
{
    Console.WriteLine("variavel temperatura null");
}