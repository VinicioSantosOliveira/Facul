"""Crie um algoritmo que calcule a área de figuras geométricas planas (fórmulas informadas) , que
contenha um MENU para escolha de qual forma será calculada. Utilize as fórmulas abaixo:
circulo: a = pi.r**2
quadrado: a = l**2
retangulo: a = base.altura"""

print("informe qual figura geometrica voce quer calcular:")
formula = int(input("digite 1 para calcular circulo, digite 2 para calcular quadrado ou digite 3 para calcular retangulo: "))

if formula == 1:
    r = float(input("informe o raio do circulo: "))
    circulo = 3.14 * (r**2)
    print("a area do circulo é ", circulo)
elif formula == 2:
    l = float(input("informe o lado do quadrado: "))
    quadrado = l**2
    print("a area do quadrado é ", quadrado)
elif formula == 3:
    base = float(input("informe a base do retangulo: "))
    altura = float(input("informe a altura do retangulo: "))
    retangulo = base * altura
    print("a area do retangulo é ", retangulo)
else:
    print("nenhuma informaçao foi fornecida")