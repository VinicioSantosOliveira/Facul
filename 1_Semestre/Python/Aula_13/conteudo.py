lista = [1, 2, 3, 4, 5]
valor = float(2/3)

print(f"o conteudo da lista é: {lista}")

"""round formata as casas depois da virgula"""
print(round(valor, 2))

novo = float(input("digite o valor: "))

"""append é pra adicionar um valor na lista"""
lista.append(novo)
print(lista)

"""insert é pra inserir o numero no lugar que eu quero da lista"""
lista.insert(0, novo)
print(lista)

"""o pop é pra remover da lista algum valor"""
lista.pop(0)
print(lista)

"""o -1 é pra começar a conta de tras pra frente, o len conta quantas casas tem na lista"""
ultimo_lista = len(lista)-1
print(lista[ultimo_lista])

