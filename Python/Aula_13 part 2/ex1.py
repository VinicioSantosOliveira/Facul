"""1. Escreva um programa que receba uma lista de números do usuário e imprima a
lista na tela."""

lista = []
i = 0

while i < 5:
    
    numero = float(input("Digite um numero para colocar na lista: "))

    lista.append(numero)
    i = i + 1

print(lista)