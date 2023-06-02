"""8. Escreva um programa que receba uma lista de números do usuário e imprima a
lista em ordem crescente."""

lista = []

i = 0

while i < 5:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    i = i + 1

lista.sort()
print(lista)