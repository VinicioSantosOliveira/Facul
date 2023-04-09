"""Cálculo de desconto: Escreva um programa que leia o valor de um produto e calcule o valor
com desconto de 10%. Se o valor do produto for maior que R$ 50,00, aplique um desconto
adicional de 5%. Exiba o valor final com desconto."""

valorProduto = float(input("Informe o valor do produto: "))

desconto10 = (valorProduto * 10)/ 100
result10 = valorProduto - desconto10

desconto5 = (result10 * 5)/ 100
result5 = result10 - desconto5

if valorProduto > 50:
    desconto5 = (result10 * 5)/ 100
    result5 = result10 - desconto5
    
    print("recebeu 5 porcento de desconto extra, valor do descontado ", result5)
else:
    print("valor do produto com 10 porcento de desconto é ", result10)