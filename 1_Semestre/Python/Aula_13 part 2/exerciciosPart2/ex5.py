"""5. Escreva um programa que receba uma lista de números do usuário e retorne a quantidade de
números ímpares presentes na lista."""

lista = []
impar = 0
i = 0

while i < 5:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    i += 1

for item in lista:
    if item%2!=0:
        impar += 1
        
print("a quantidade de numeros pares foi de ", impar)