while True:
    print("Selecione uma opção.")
    print("1. Criar alunos")
    print("2. Ler alunos")
    print("3. Buscar aluno por ID")
    print("4. Atualizar aluno")
    print("5. Excluir aluno")
    print("0. Sair")

    opcao = input("digite o numero da opção desejada: ")

    #Cadastro do aluno
    if opcao == 1:

        nomeAluno = input("Digite seu nome: ")
        idadeAluno = input("Digite sua idade: ")

        alunoID = 1

        pass
    #Consultar aluno
    elif opcao == 2:
        pass
    #Busca aluno por ID
    elif opcao == 3:
        pass
    #Atualiza por ID
    elif opcao == 4:
        pass
    #Excluir aluno
    elif opcao == 5:
        pass
    #SAIR DO PROGRAMA
    elif opcao == 0:
        break
    else:
        print("Opção invalida. Por favor, digite novamente.")