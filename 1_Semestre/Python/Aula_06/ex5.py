"""Verificação de número positivo: Escreva um programa que leia um número e verifique se ele
é positivo ou negativo. Se for positivo, exiba a mensagem "O número é positivo". Caso
contrário, exiba "O número é negativo"."""

n = int(input("digite um valor: "))

if n > 0:
    print("O número é positivo")
elif n == 0:
    print("o valor informado é 0")
else:
    print("O número é negativo")