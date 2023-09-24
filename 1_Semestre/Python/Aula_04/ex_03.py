"""3. Você está desenvolvendo um programa que verifica se um número é par ou ímpar. Para isso, você
precisa solicitar o número e verificar se ele é divisível por 2. Se o número for divisível por 2, o
programa deve informar que o número é par, caso contrário, o programa deve informar que o número
é ímpar."""

numero = int(input("digite um numero: "))

if numero%2==0:
    print("O numero informado é PAR")
else:
    print("O numero informado é IMPAR")