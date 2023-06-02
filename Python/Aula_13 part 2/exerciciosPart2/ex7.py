"""7. Escreva um programa que receba uma lista de números do usuário e retorne uma lista com
apenas os números ímpares presentes na lista."""

#ex repetido

lista = []

i = 0

while i < 5:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    i += 1

    if numero%2 != 0:
        print(lista)
    else:
        print(lista.pop())

print(lista)