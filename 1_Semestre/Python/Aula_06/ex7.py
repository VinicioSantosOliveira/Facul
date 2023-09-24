"""Verificação de senha: Escreva um programa que peça ao usuário uma senha e verifique se
ela é válida ou não. Considere uma senha válida aquela que possui pelo menos 8
caracteres, contendo pelo menos uma letra maiúscula e um número. Se a senha for válida,
exiba a mensagem "Senha válida". Caso contrário, exiba "Senha inválida"."""

senha = str(input("digite uma senha: "))

valida = "Vinicio123"

if senha == valida:
    print("Senha válida")
else:
    print("senha invalida")