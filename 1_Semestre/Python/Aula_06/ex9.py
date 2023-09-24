"""Verificação de ano bissexto: Escreva um programa que peça ao usuário um ano e verifique
se ele é bissexto ou não. Um ano é bissexto se for divisível por 4 e não for divisível por 100,
exceto quando é divisível por 400. Se o ano for bissexto, exiba a mensagem "O ano é
bissexto". Caso contrário, exiba "O ano não é bissexto"."""

ano = int(input("informe um ano: "))

if ano % 100 != 0 and ano % 4 == 0 or ano % 400 == 0:
    print(ano ," é bisexto!")
else:
    print(ano ," nao é bissexto")