"""5. Você está desenvolvendo um programa para calcular a distância percorrida por um objeto em um
movimento uniformemente acelerado. O usuário deve informar a velocidade inicial, a aceleração e o
tempo de deslocamento. Escreva um algoritmo que calcule e imprima a distância percorrida pelo
objeto."""

velocidadeInicial = float(input("Informe a velocidade inicial: "))
aceleracaoInicial = float(input("Informe a aceleraçao inicial: "))
tempoDeslocamento = float(input("Informe a tempo de deslocamento: "))

distanciaPercorrida = (velocidadeInicial * tempoDeslocamento)+ aceleracaoInicial *(tempoDeslocamento**2 / 2)

print("a distancia percorrida pelo objeto foi ", distanciaPercorrida)