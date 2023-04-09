"""1. Você está desenvolvendo um programa para calcular a corrente elétrica em um circuito elétrico. O
usuário deve informar a resistência elétrica e a tensão elétrica do circuito. Escreva um algoritmo que
calcule e imprima a corrente elétrica do circuito, de acordo com a lei de Ohm."""


resistenciaEletrica = float(input("Informe a resistencia eletrica: "))
tensaoEletrica = float(input("Informe a tensao eletrica: "))

correnteEletrica = tensaoEletrica / resistenciaEletrica

print("a corrente eletrica é ", correnteEletrica)