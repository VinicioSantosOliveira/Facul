//concatenaçao
String nome = "Vinicio";
int idade = 20;

Console.WriteLine(nome +" Tem "+ idade +" anos");

//interpolaçao utilizando chaves

Console.WriteLine($"{nome} tem {idade} anos");

//placeholders

Console.WriteLine("{0} tem {1} anos", nome, idade);

//usando sequencias de escapes

String local = "C:\\Users\\vinicio";
Console.WriteLine(local);

String frase = "Ela falou: \"nao fui eu\"";
Console.WriteLine(frase);

String pizza = "\npizza \nde \nmussarela";
Console.WriteLine(pizza);