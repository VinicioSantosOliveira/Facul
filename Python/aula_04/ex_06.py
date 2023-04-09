"""6. Você está desenvolvendo um programa para classificar triângulos de acordo com as medidas de
seus lados. O usuário deve informar as medidas dos três lados do triângulo. Escreva um algoritmo
que determine e imprima se o triângulo é equilátero, isósceles ou escaleno."""

lado1 = float(input("informe o lado 1 do triangulo: "))
lado2 = float(input("informe o lado 2 do triangulo: "))
lado3 = float(input("informe o lado 3 do triangulo: "))

if lado1 == lado2 == lado3:
    print("O triangulo é equilátero")
elif lado1 == lado2 != lado3 or lado1 == lado3 != lado2 or lado1 != lado2 == lado3:
    print("O triangulo é isósceles")
else:
    print("O triangulo é escaleno")