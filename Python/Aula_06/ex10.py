"""Verificação de vogal: Escreva um programa que leia uma letra e verifique se ela é uma vogal
ou não. Se for uma vogal, exiba a mensagem "A letra é uma vogal". Caso contrário, exiba "A
letra é uma consoante"."""

letra = str(input("informe uma letra: "))

if letra == "a" or letra == "e" or letra == "i" or letra == "o" or letra == "u":
    print("A letra é uma vogal")
else:
    print("A letra é uma consoante")