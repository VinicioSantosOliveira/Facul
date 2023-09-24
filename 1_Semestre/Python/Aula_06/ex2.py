"""Verificação de idade: Escreva um programa que peça a idade do usuário e verifique se ele é
maior de idade ou não. Se for maior de idade, exiba a mensagem "Você é maior de idade".
Caso contrário, exiba "Você é menor de idade"."""

idade = int(input("informe sua idade: "))

if idade >= 18:
    print("Você é maior de idade")
else:
    print("Você é menor de idade")