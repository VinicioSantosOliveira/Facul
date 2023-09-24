"""4. Escreva um programa que receba uma lista de números do usuário e calcule a
média de todos os números presentes na lista."""

lista = []

i = 0

while i < 3:

    numero = int(input("Digite um numero: "))

    lista.append(numero)

    i = i + 1

result = sum(lista) / len(lista)
print(result)