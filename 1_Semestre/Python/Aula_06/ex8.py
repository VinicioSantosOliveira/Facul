"""Cálculo de imposto: Escreva um programa que leia o salário de um funcionário e calcule o
valor do imposto a ser pago, considerando as seguintes faixas salariais: até R$ 1.000,00,
isento de imposto; de R$ 1.000,00 a R$ 2.000,00, 10% de imposto; acima de R$ 2.000,00,
20% de imposto."""

salario = float(input("Informe seu salario: "))

if salario < 1000:
    print("voce esta insento de imposto de renda")

elif salario >= 1000 or salario < 2000:
    imposto10 = (salario * 10)/ 100
    ir10 = salario - imposto10
    pago10 = salario - ir10

    print("o imposto de renda e de 10 porcento e valor a ser pago é ", pago10)
    print("o seu salario final sera ", ir10)

else:
    imposto20 = (salario * 20)/ 100
    ir20 = salario - imposto20
    pago20 = salario - ir20

    print("o imposto de renda e de 20 porcento e valor a ser pago é", ir20)
    print("o sei salario final é de ", ir20)