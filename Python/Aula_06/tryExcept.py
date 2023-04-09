while True:
    try: #usado para evitar erro no programa
        numero = int(input("digite um valor inteiro: "))
    except ValueError:
        print("digite um valor INT")
        continue #continue é do while, nao do try