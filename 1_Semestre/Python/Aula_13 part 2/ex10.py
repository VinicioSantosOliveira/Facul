"""10.Escreva um programa que receba uma lista de números do usuário e verifique se
um número específico está presente na lista."""

lista = []

i = 0

while i < 5:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    i = i + 1

for item in lista:
    if item == 5:
        print(lista ," possui o numero 5 em especifico")
    else:
        print(lista ," nao possui o numero 5 em especifico")