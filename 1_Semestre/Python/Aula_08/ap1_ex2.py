"""Crie um algoritmo que receba o nome, sexo, idade e tempo de trabalho (contribuição).
Com base nos seguintes requisitos para aposentadoria: 
Mulheres - 30 anos de contribuição e 55 anos de idade
Homens - 35 anos de contribuição e 60 anos
Diga se as pessoas consultadas podem ou não requerer a aposentadoria.
Armazene as informações de quantas pessoas foram consultadas, por exemplo: esta é a consulta número XX.
Necessário MENU com interface para usuário (no terminal, não é tela gráfica!)."""

contador = 1

while True:
    escolha = int(input("digite [1] para pesquisar sobre uma pessoa ou digite [2] para sair: "))

    if escolha == 1:
        nome = str(input("informe seu nome: "))
        sexo = str(input("informe seu sexo. digite [M] para masculino ou digite [F] para feminidade: "))
        idade = int(input("informe sua idade: "))
        tempoTrabalho = int(input("informe o tempo de trabalho(contribuiçao) dessa pessoa: "))

        if sexo == "m" and tempoTrabalho >= 35 and idade >= 60:
            print(nome ,", ja pode pedir a aposentadoria. esta é a consulta numero", contador)
        elif sexo == "f" and tempoTrabalho >= 30 and idade >= 55:
            print(nome ,", ja pode pedir a aposentadoria. esta é a consulta numero", contador)
        else:
            print(nome ," nao pode pedir a aposentadoria ainda. esta é a consulta numero", contador)
        
        contador += 1

    elif escolha == 2:
        print("Saindo...")
        break
    else:
        print("opçao invalida")