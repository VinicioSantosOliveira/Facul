"""11. Escreva um programa que receba uma lista de nomes do usuário e determine se todos os
nomes possuem a mesma quantidade de caracteres."""

lista = []

while True:
    nome = input("Digite um nome: ")

    if nome == "sair":
        break
    else:
        lista.append(nome)

"""for item in lista:
    if item == (lista):
        print("mesmo tamanho")"""