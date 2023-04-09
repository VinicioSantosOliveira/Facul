"""7. João é um médico que trabalha em uma clínica especializada em saúde preventiva. Ele está
desenvolvendo um programa para calcular o IMC (Índice de Massa Corporal) de seus pacientes. O
IMC é uma medida que relaciona o peso e a altura de uma pessoa e é utilizada para verificar se ela
está com o peso ideal. João sabe que, para calcular o IMC, ele precisa da altura e do peso do
paciente. Escreva um algoritmo em Python que ajude João a calcular o IMC de seus pacientes."""

altura = float(input("Informe sua altura: "))
massa = int(input("Informe seu peso: "))

imc = massa /(altura * altura)

if imc < 18.5:
    print("Seu imc é ", imc ,"e voce esta abaixo do peso")
elif imc >= 18.5 and imc < 25:
    print("Seu imc é ", imc ,"e voce esta no peso ideal")
elif imc >= 25 and imc < 30:
    print("Seu imc é ", imc ," e voce esta com sobrepeso")
elif imc >= 30 and imc < 35:
    print("Seu imc é ", imc ," e voce esta com obesidade nvl 1")
elif imc >= 35 and imc < 40:
    print("Seu imc é ", imc ," e voce esta com obesidade nvl 2")
else:
    print("Seu imc é ", imc ," e voce esta com obesidade nvl 3")


    """se
			(imc<=17)
			escreva ("\nvoce esta muito abaixo do peso")
		se
			(imc>=17 e imc<18.5)
			escreva ("\nvoce esta abaixo do peso")
		se
			(imc>=18.5 e imc<25)
			escreva ("\nvoce esta no peso ideal")asdasd
		se
			(imc>=25 e imc<30)
			escreva ("\nvoce esta com sobrepeso")adasd
		se
			(imc>=30 e imc<35)
			escreva ("\nvoce esta obeso")
		se
			(imc>=35 e imc<40)
			escreva ("\nvoce esta com obesidade severa")
		se
			(imc>=40 e imc<=50)
			escreva ("\nvoce esta com obesidade mórbida")
		senao
			escreva ("\nProcure um medico")"""