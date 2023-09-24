"""2. Escreva um programa que receba uma lista de números do usuário e retorne o menor número
presente na lista."""

lista = []

"""i = 0
menorN = 100

while i < 5:
    numero = int(input("digite um numero: "))

    lista.append(numero)

    i = i + 1

for item in lista:
    if item < menorN:
        menorN = item

print(menorN)"""

while True:
    numero = int(input("Digite um valor: "))

    if numero == 0:
        break
    else:
        lista.append(numero)
        
print(min(lista))