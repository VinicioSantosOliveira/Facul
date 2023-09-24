"""Verificação de números pares: Escreva um programa que leia um número inteiro e verifique
se ele é par ou ímpar. Se for par, exiba a mensagem "O número é par". Caso contrário, exiba
"O número é ímpar"."""

n = int(input("digite um valor: "))

if n%2==0:
    print("o valor é PAR")
else:
    print("o valor é IMPAR")