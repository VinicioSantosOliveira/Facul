//6 - Crie um novo script que leia um número que só pode ser de 1 a 7 e imprima os dias da semana sendo 1 = domingo e 7 = sábado.

let numero = Number(prompt("digite um numero entre 1 e 7:"))

switch (numero){
    case 1:
        alert("Domingo")
        break
    case 2:
        alert("Segunda")
        break
    case 3:
        alert("Terça")
        break
    case 4:
        alert("Quarta")
        break
    case 5:
        alert("Quinta")
        break
    case 6:
        alert("Sexta")
        break
    case 7:
        alert("Sabado")
        break
    default:
        alert("Digite um numero valido.")
}