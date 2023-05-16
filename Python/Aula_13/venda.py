"""faça um algoritmo que venda 4 produtos, sendo eles: refri, bolo, agua e cafe. O cliente pode compra quantos produtos quiser desses 4 e no final dizer qual valor total que deu tudo e dizer a quantidade comprada de cada produto."""

refri = 0
bolo = 0
agua = 0
cafe = 0

lista = []

print("            MENU            ")
print("digite [1] para comprar refri")
print("digite [2] para comprar bolo")
print("digite [3] para comprar agua")
print("digite [4] para comprar cafe")
print("digite [5] para finalizar compra")

while(True):

    opcao = int(input("Opçao: "))

    if opcao == 1:
        lista.append(8)
        print("Refri R$8,00")
        refri = refri + 1

    elif opcao == 2:
        lista.append(10)
        print("bolo R$10,00")
        bolo = bolo + 1

    elif opcao == 3:
        lista.append(5)
        print("agua R$5,00")
        agua = agua + 1

    elif opcao == 4:
        lista.append(15)
        print("cafe R$15,00")
        cafe = cafe + 1

    else:
        print("Finalizando..")
        break

print("O valor total foi de R$", sum(lista))
print("Quantia de:")
print(f"    refri: {refri}, bolo: {bolo}, agua: {agua}, cafe: {cafe}")