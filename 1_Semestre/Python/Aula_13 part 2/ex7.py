"""7. Escreva um programa que receba uma lista de números do usuário e imprima
apenas os números que são múltiplos de 3 e 5 simultaneamente."""

lista = []

i = 0

while i < 3:
    numero = int(input("digite um valor: "))
    
    lista.append(numero)

    i = i + 1

for item in lista:
    if item % 3 == 0 and item % 5 == 0:
        print(item ," é multiplo de 3 e 5 simultaneamente")