valorInicial = float (input ("Informe o valor investido inicialmente: "))
taxaJuros = float (input ("Informe qual a taxa de juros: "))
tempoDeAplicacao = float (input ("Informe qual foi o tempo de aplicação: "))

juros = (valorInicial * taxaJuros * tempoDeAplicacao)/ 100
valorFinal = valorInicial + juros

print ("O valor final da aplicação financeira foi de ", valorFinal)