"""Cálculo de média: Escreva um programa que leia três notas e calcule a média do aluno. Se a
média for maior ou igual a 7, exiba a mensagem "Aprovado". Caso contrário, exiba
"Reprovado"."""

nota1 = float(input("informe a primeira nota: "))
nota2 = float(input("informe a segunda nota: "))
nota3 = float(input("informe a terceira nota: "))

media = (nota1 + nota2 + nota3) / 3

if media >= 7.0:
    print("a sua media é:", media, ". voce foi APROVADO")
else:
    print("a sua media é:", media, ". voce foi REPROVADO")