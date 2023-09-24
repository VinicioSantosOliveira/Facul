"""5. Escreva um programa que receba uma lista de números do usuário e imprima
apenas os números pares presentes na lista."""

lista = []

"""i = 0

while i < 5:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    if numero%2 == 0:
        print(lista)
    else:
        print(lista.pop())

    i = i + 1

print(lista)"""

while True:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    for i in lista:
        if i%2==0:
            print(i, " é par")