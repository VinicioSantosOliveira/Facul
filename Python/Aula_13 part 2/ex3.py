"""3. Escreva um programa que receba uma lista de números do usuário e calcule a
soma de todos os números presentes na lista."""

lista = []
i = 0

while i < 3:
    numero = int(input("digite um numero: "))

    lista.append(numero)
    
    i = i + 1

print (sum(lista))