# Loop principal do programa
alunos=[]
while True:
    print("Selecione uma opção:")
    print("1. Criar aluno")
    print("2. Ler alunos")
    print("3. Buscar aluno por ID")
    print("4. Atualizar aluno")
    print("5. Excluir aluno")
    print("0. Sair")

    opcao = input("Digite o número da opção desejada: ")

    # Cadastro do aluno
    if opcao == "1":
        nome=input("digite o nome do aluno:")
        idade=int(input("digite a idade do aluno:"))
        if len (alunos)==0:
            id_aluno=1
        else:
            id_aluno=alunos[-1][0] + 1

            
        dados_aluno=[id_aluno,nome,idade]
        alunos.append(dados_aluno)
        
        print("aluno criado com sucesso.")
        print(alunos)