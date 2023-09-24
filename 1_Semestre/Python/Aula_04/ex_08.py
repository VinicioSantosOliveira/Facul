"""8. Maria é uma estudante de física que está desenvolvendo um programa para converter uma
temperatura de Celsius para Fahrenheit. Ela sabe que muitas vezes precisa realizar essa conversão
em seus estudos, mas a fórmula matemática pode ser confusa. Por isso, ela está desenvolvendo um
programa em Python que simplifica esse processo. Escreva um algoritmo que ajude Maria a
converter uma temperatura de Celsius para Fahrenheit."""

celcius = float(input("Qual temperatura em celcius deseja converter para fahrenheit? "))

fahrenheit = celcius * 1.8 + 32

print("A temperatura em fahrenheit é: ", fahrenheit)