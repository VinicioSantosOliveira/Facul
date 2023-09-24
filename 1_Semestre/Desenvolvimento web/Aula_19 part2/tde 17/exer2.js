//2 - Faça um script que leia um número e mostre uma mensagem indicando se este número é par ou ímpar e se é positivo ou negativo.

let numero = Number(prompt("digite um numero:"))

if (numero % 2 == 0){
    alert("o numero informado é PAR")
    
    if (numero >= 0){
        alert("o numero é POSITIVO")
    }
    else{
        alert("o numero é NEGATIVO")
    }
}
else{
    alert("o numero informado é IMPAR")

    if (numero >= 0){
        alert("o numero é POSITIVO")
    }
    else{
        alert("o numero é NEGATIVO")
    }
}