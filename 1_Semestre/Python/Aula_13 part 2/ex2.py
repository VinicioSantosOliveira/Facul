"""2. Escreva um programa que receba uma lista de nomes do usuário e imprima cada
nome em uma linha separada."""

lista = []
i = 0

"""while i < 4:
    nome = str(input("digite um nome: "))

    lista.append(nome)

    i = i + 1

print(lista[0])
print(lista[1])
print(lista[2])
print(lista[3])"""

while True:
    nome = str(input("Digite um nome: "))

    if nome.lower() == "sair":  #lower() serve para converter tudo que foi digitado em letras minusculas
        break
    else:
        lista.append(nome)

for item in lista:  # "item in lista" vai ler toda a lista no print (pode ser qualquer nome ao inves de item)
    print(item)