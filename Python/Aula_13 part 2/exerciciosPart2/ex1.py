"""1. Escreva um programa que receba uma lista de números do usuário e retorne o maior número
presente na lista."""

lista = []

"""i = 0
maiorN = 0

while i < 5:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    i = i + 1

for item in lista:
    if item > maiorN:
        maiorN = item

print(maiorN)"""

while True:
    numero = int(input("Digite um valor: "))

    if numero == 0:
        break
    else:
        lista.append(numero)
        
print(max(lista))