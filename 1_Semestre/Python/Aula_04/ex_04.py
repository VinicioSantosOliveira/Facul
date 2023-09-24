"""4. Você está desenvolvendo um programa para calcular a altura máxima e o tempo de queda de um
objeto em um lançamento vertical. O usuário deve informar a altura inicial do objeto. Assuma que a
aceleração da gravidade é igual a 9,81 m/s². Escreva um algoritmo que calcule e imprima a altura
máxima e o tempo de queda do objeto."""

alturaInicial = float(input("informe a altura do objeto: "))
gravidade = 9.81
velocidadeInicial = float(input("informe a velocidade inicial: "))

t = velocidadeInicial / gravidade

y = alturaInicial + (velocidadeInicial * t) - ((gravidade * t**2) / 2)

print("tempo de queda: ", t)
print("altura maxima: ", y)












"""import math

# lê a altura inicial do objeto do usuário
h = float(input("Digite a altura inicial do objeto em metros: "))

# define a aceleração da gravidade
g = 9.81 # m/s^2

# calcula o tempo de queda
t = math.sqrt((2 * h) / g)

# calcula a altura máxima
h_max = (g * t**2) / 2

# imprime os resultados
print("A altura máxima atingida pelo objeto é:", round(h_max, 2), "metros.")
print("O tempo de queda do objeto é:", round(t, 2), "segundos.")"""