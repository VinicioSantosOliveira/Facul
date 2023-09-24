"""6. Escreva um programa que receba uma lista de números do usuário e imprima
apenas os números ímpares presentes na lista."""

lista = []
i = 0

while i < 3:

    numero = int(input("digite um valor: "))

    lista.append(numero)

    print(lista)

    i = i + 1

for item in lista:
    if item % 2 != 0:
        print(item ," é impar")