"""15. Escreva um programa que receba uma lista de números do usuário e retorne uma lista sem
duplicatas."""

lista = []

while True:

    numero = int(input("digite um numero: "))

    if numero == 0:
        break
    else:
        lista.append(numero)
        print(lista)

semDuplicado = []

for item in lista:
    if item not in semDuplicado:
        semDuplicado.append(item)

print(semDuplicado)