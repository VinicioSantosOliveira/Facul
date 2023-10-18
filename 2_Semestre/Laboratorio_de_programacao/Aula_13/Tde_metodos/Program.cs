Mensagem msg = new();
msg.exibir();

Quadrado quadrado = new();
quadrado.numero = 20;
quadrado.calcularEImprimirQuadrado();

CalculadoraSimples calc = new();
Console.WriteLine(calc.somar(2,4));
Console.WriteLine(calc.somar(2,3,5));

Concatenador conc = new();
Console.WriteLine(conc.concatenar("ass", "im"));
Console.WriteLine(conc.concatenar("ass", "im", "a"));

ConversorTemperatura c = new();
c.temperaturaCelsius = 15;
Console.WriteLine(c.converterParaFahrenheit());

Data date = new();
date.dia = 11;
date.mes = 09;
date.ano = 2001;
date.imprimirDataFormatada();

CalculadoraArea area = new();
area.calcularArea(4,10);

Tabuada tabuada = new();
tabuada.numeroBase = 5;
tabuada.imprimirTabuada();